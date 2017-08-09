﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure_Scrolls_of_Martial_Prowess.Models;

namespace Azure_Scrolls_of_Martial_Prowess.Controllers
{
    public class CombatController
    {
        public Combat currentCombat { get; set; }
        public SortedList<int, String> initiativeList { get; set; }

        public CombatController()
        {
            this.currentCombat = new Combat();
        }

        public Boolean AddCharacter(Character newParticipant)
        {
            Boolean res = false;
            res = currentCombat.AddCharacter(newParticipant);
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

        public void ResetActed()
        {
            foreach(Character particpant in currentCombat.Participants)
            {
                particpant.HasActedThisRound = false;
            }
        }

        private void UpdateContinuousEffects()
        {
            foreach (Character charPres in currentCombat.Participants)
            {
                UpdateContinuousEffectsForCharacter(charPres);
            }
        }

        private void AddMotes()
        {
            foreach (Character charPres in currentCombat.Participants)
            {
                int motesLeft = 5;
                //Try to add motes to Peripheral first
                int missingInPeripheral = Math.Max(charPres.PeripheralEssence - charPres.CurrentPeripheralEssence, 0);
                int missingInPersonal = Math.Max(charPres.PersonalEssence - charPres.CurrentPersonalEssence, 0);
                //Try & Fill peripheral first
                if (missingInPeripheral >= motesLeft)
                {
                    charPres.CurrentPeripheralEssence += motesLeft;
                    motesLeft = 0;
                }
                //Try & Fill personal second
                if (missingInPersonal >= motesLeft)
                {
                    charPres.CurrentPersonalEssence += motesLeft;
                    motesLeft = 0;

                }
                //Splits needed
                if(missingInPeripheral<motesLeft )
                {
                    charPres.CurrentPeripheralEssence += missingInPeripheral;
                    motesLeft -= missingInPeripheral;
                }

                if (missingInPersonal >= motesLeft)
                {
                    charPres.CurrentPersonalEssence += motesLeft;
                    motesLeft = 0;

                }
                if (missingInPersonal < motesLeft)
                {
                    charPres.CurrentPersonalEssence += missingInPersonal;
                    motesLeft -= missingInPersonal;
                }
            }
        }

        private void UpdateContinuousEffectsForCharacter(Character toUpdate)
        {
            List<Effect> toRemove = new List<Effect>();
            foreach (Effect effect in toUpdate.CurrentEffects)
            {
                if (effect.temporary)
                {
                    effect.remainingTurns--;
                    if (effect.remainingTurns <= 0)
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
            initiativeList = new SortedList<int, string>(new DescendingOrderComperator());
            
            
            foreach (Character charPres in currentCombat.Participants)
            {
                initiativeList.Add(charPres.CurrentInitiative, charPres.Name);
            }


        }

        //Quick descending order comperator
        private class DescendingOrderComperator : IComparer<int>
        {
            int IComparer<int>.Compare(int x, int y)
            {
                if (x == y) return -1;
                if (x < y) return 1;
                if (x > y) return -1;
                return 0;

            }
        }

        public void handle_init_list_update(object sender, System.EventArgs e)
        {
            //only init or has acted can be updated here
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            //Retrieve data from event
            String name =(String) row.Cells[1].Value;
            int rowInit = Int32.Parse((string) row.Cells[0].Value);
            bool rowHasActed = (Boolean) row.Cells[3].Value;
            Character toUpdate = currentCombat.GetCharacter(name);
            //Update init
            if(rowInit != toUpdate.CurrentInitiative)
            {
                toUpdate.CurrentInitiative = rowInit;
            }
            //Update hasActed
            if(rowHasActed != toUpdate.HasActedThisRound)
            {
                toUpdate.HasActedThisRound = rowHasActed;
            }
        }
    }
}
