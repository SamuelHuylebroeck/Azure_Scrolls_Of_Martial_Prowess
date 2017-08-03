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
        }

        private void UpdateContinuousEffects()
        {
            foreach(Character charPres in CurrentCombat.Participants.Values)
            {
                UpdateContinuousEffectsForCharacter(charPres);
            }
        }

        private void AddMotes()
        {

        }

        private void UpdateContinuousEffectsForCharacter(Character toUpdate)
        {
            List<Effect> toRemove = new List<Effect>();
            foreach (Effect effect  in toUpdate.CurrentEffects)
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
            foreach(Effect tr in toRemove)
            {
                toUpdate.CurrentEffects.Remove(tr);
            }
        }

    }
}
