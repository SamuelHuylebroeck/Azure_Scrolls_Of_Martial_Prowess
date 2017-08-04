using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure_Scrolls_of_Martial_Prowess.Models;

namespace Azure_Scrolls_of_Martial_Prowess.Controllers
{
    public class CombatController
    {
        public Combat CurrentCombat { get; set; }
        public SortedList<int, String> InitList { get; set; }

        public CombatController()
        {
            this.CurrentCombat = new Combat();
        }


        public Boolean AddCharacter(Character newParticipant)
        {
            Boolean res = false;
            res = CurrentCombat.AddCharacter(newParticipant);
            return res;
        }

        public void NextRound()
        {
            //Resolve continious effects
            UpdateContinuousEffects();
            //Add end of round motes
            AddMotes();
            //Update initiative
            UpdateInitiative();
            //Remove dead characters
        }

        private void UpdateContinuousEffects()
        {
            foreach (Character charPres in CurrentCombat.Participants)
            {
                UpdateContinuousEffectsForCharacter(charPres);
            }
        }

        private void AddMotes()
        {
            foreach (Character charPres in CurrentCombat.Participants)
            {
                int motesLeft = 5;
                //Try to add motes to Peripheral first
                int missingInPeripheral = Math.Max(charPres.PeripheralEssence - charPres.CurrentPeripheralEssence, 0);
                int missingInPersonal = Math.Max(charPres.PersonalEssence - charPres.CurrentPersonalEssence, 0);
                if (missingInPeripheral >= motesLeft)
                {
                    charPres.CurrentPeripheralEssence += motesLeft;
                    motesLeft = 0;
                }
                else
                {
                    if (missingInPeripheral > 0)
                    {
                        charPres.CurrentPeripheralEssence += missingInPeripheral;
                        motesLeft -= missingInPeripheral;
                    }
                }
                if (missingInPersonal > motesLeft)
                {
                    charPres.CurrentPersonalEssence += motesLeft;
                }
                else
                {
                    charPres.CurrentPersonalEssence += missingInPersonal;
                }
            }
        }

        private void UpdateContinuousEffectsForCharacter(Character toUpdate)
        {
            List<Effect> toRemove = new List<Effect>();
            foreach (Effect effect in toUpdate.CurrentEffects)
            {
                if (effect.Temporary)
                {
                    effect.RemainingTurns--;
                    if (effect.RemainingTurns <= 0)
                    {
                        toRemove.Add(effect);
                    }
                }
            }
            foreach (Effect tr in toRemove)
            {
                toUpdate.CurrentEffects.Remove(tr);
            }
        }

        private void UpdateInitiative()
        {
            InitList = new SortedList<int, string>();
            foreach (Character charPres in CurrentCombat.Participants)
            {
                InitList.Add(charPres.CurrentInitiative, charPres.Name);
            }
        }
    }
}
