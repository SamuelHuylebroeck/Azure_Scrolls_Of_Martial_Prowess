using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure_Scrolls_of_Martial_Prowess.Models;
using Azure_Scrolls_of_Martial_Prowess.Util;
using Azure_Scrolls_of_Martial_Prowess.Views;

namespace Azure_Scrolls_of_Martial_Prowess.Controllers
{
    public class CombatController
    {
        public Combat currentCombat { get; set; }
        public SortedList<int, String> initiativeList { get; set; }
        public Character currentFocus { get; set; }
        private MainScreen mainScreen;

        public CombatController()
        {
            this.currentCombat = new Combat();
            this.initiativeList = new SortedList<int, string>(new DescendingOrderComperator());
            this.currentFocus = null;
            this.mainScreen = null;
        }

        public void RegisterMainScreen(MainScreen toRegister)
        {
            this.mainScreen = toRegister;
        }

        #region Data Insertion
        public Boolean AddCharacter(Character newParticipant)
        {
            Boolean res = false;
            res = currentCombat.AddCharacter(newParticipant);
            if (res)
            {
                initiativeList.Add(newParticipant.CurrentInitiative, newParticipant.Name);
                if (mainScreen != null)
                {
                    mainScreen.RedrawCombatTable();
                }
            }
            return res;
        }

        public Boolean AddEffectToFocus(Effect effectToAdd)
        {
            Boolean res = false;
            if (currentFocus != null)
            {
                try
                {
                    currentFocus.CurrentEffects.Add(effectToAdd);
                    res = true;
                    if (mainScreen != null)
                    {
                        mainScreen.RedrawFocus();
                    }
                }
                catch (Exception e)
                {
                    //Res is already default set to false, but set it again in case exception is triggered in Redraw
                    res = false;
                }
            }
            return res;
            
        }

        public void UpdateFocus(Character newFocus)
        {
            currentFocus = newFocus;
            if (mainScreen != null)
            {
                mainScreen.RedrawFocus();
            }
        }

        #endregion Data Insertion

        #region Data Access
        public Character GetCharacter(String name)
        {
            return this.currentCombat.GetCharacter(name);
        }

        /// <summary>
        /// Removes a character from combat and re-enables new delete windows
        /// </summary>
        
        ///
        public Boolean DeleteCharacter(String name)
        {

            Boolean result=  RemoveCharacter(name);
            if(mainScreen != null)
            {
                mainScreen.DeleteWindowOpen = false;
            }
            return result;
        }
        /// <summary>
        /// Removes a character from combat, does not re-enable new delete windows
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Boolean RemoveCharacter(String name)
        {
            Boolean result = false;
            result = currentCombat.RemoveCharacter(name);
            result = result && RemoveFromInitList(name);
            if (result && mainScreen != null && !mainScreen.RedrawingCombatTable)
            {
                mainScreen.RedrawCombatTable();
                if (currentFocus.Name.Equals(name))
                {
                    currentFocus = null;
                    if (!mainScreen.RedrawingFocus)
                    {
                        mainScreen.RedrawFocus();
                    }
                }
            }
            return result;
        }

        private Boolean RemoveFromInitList(String name)
        {
            Boolean result = false;
            int toRemovePosition = -1;
            for(int i =0;i<initiativeList.Count;i++)
            {
                KeyValuePair<int, String> kvp = initiativeList.ElementAt(i);
                if (kvp.Value.Equals(name))
                {
                    result = true;
                    toRemovePosition = i;
                }
            }
            if (result) initiativeList.RemoveAt(toRemovePosition);
            return result;
        }
        #endregion Data Access

        #region Update Logic
        public void NextRound()
        {
            //Remove dead characters
            RemoveDeadCharacters();
            //Resolve continious effects
            UpdateContinuousEffects();
            //Add end of round motes
            AddMotes();
            //Reset acted
            ResetActed();
            //Update initiative
            UpdateInitiative();


            //update view
            if (mainScreen != null)
            {
                mainScreen.RedrawCombatTable();
                mainScreen.RedrawFocus();
            }
        }

        public void ResetActed()
        {
            foreach (Character particpant in currentCombat.Participants)
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
                if (missingInPeripheral < motesLeft)
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
            initiativeList.Clear();

            foreach (Character charPres in currentCombat.Participants)
            {
                initiativeList.Add(charPres.CurrentInitiative, charPres.Name);
            }

        }

        private void UpdateInitiative(Character toUpdate)
        {
            int position = initiativeList.IndexOfValue(toUpdate.Name);
            if (position >= 0)
            {
                initiativeList.RemoveAt(position);
                initiativeList.Add(toUpdate.CurrentInitiative, toUpdate.Name);
            }
        }

        private void RemoveDeadCharacters()
        {
            List<Character> toRemove = new List<Character>();
            foreach (Character charPres in currentCombat.Participants)
            {
                if (!charPres.Battlegroup)
                {
                    if (charPres.IsOut())
                    {
                        toRemove.Add(charPres);
                    }
                }
                else
                {
                    if (((Battlegroup)charPres).IsOut())
                    {
                        toRemove.Add(charPres);
                    }
                }
            }
            foreach(Character outChar in toRemove)
            {
                RemoveCharacter(outChar.Name);
                
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

        public void UpdateFocusCharacter(Constants.Characteristic code, object newValue)
        {
            switch (code)
            {
                case Constants.Characteristic.INIT:
                    int newInit = (int)newValue;
                    currentFocus.CurrentInitiative = newInit;
                    UpdateInitiative(currentFocus);
                    break;
                case Constants.Characteristic.PSE:
                    int newPersonalEssence = (int)newValue;
                    currentFocus.CurrentPersonalEssence = newPersonalEssence;
                    break;
                case Constants.Characteristic.PRE:
                    int newPeripheralEssence = (int)newValue;
                    currentFocus.CurrentPeripheralEssence = newPeripheralEssence;
                    break;
                case Constants.Characteristic.WP:
                    int newWillpower = (int)newValue;
                    currentFocus.CurrentWillPower = newWillpower;
                    break;
                case Constants.Characteristic.A:
                    String newAnima = (String)newValue;
                    currentFocus.CurrentAnimaLevel = newAnima;
                    break;
                case Constants.Characteristic.O:
                    int newOnslaught = (int)newValue;
                    currentFocus.CurrentOnslaught = newOnslaught;
                    break;
                default:
                    break;
            }
            if (mainScreen != null )
            {
                //Let the view update the focus character
                if(!mainScreen.RedrawingFocus) mainScreen.RedrawFocus();
                if(!mainScreen.RedrawingCombatTable) mainScreen.RedrawCombatTable();
            }
        }
        #endregion Update Logic

        #region Event Handling
        public void handle_init_list_update(object sender, System.EventArgs e)
        {
            //only init or has acted can be updated here
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            //Retrieve data from event
            String name = (String)row.Cells[1].Value;
            Boolean needToParse = !(row.Cells[0].Value is int);
            int rowInit = 0;
            if (!needToParse) rowInit = (int)row.Cells[0].Value;
            Boolean parseSuccesful = needToParse ? int.TryParse((string)row.Cells[0].Value, out rowInit) : true;
            if (parseSuccesful && row.Cells[3].Value != null)
            {
                bool rowHasActed = (Boolean)row.Cells[3].Value;
                Character toUpdate = currentCombat.GetCharacter(name);
                //Update init
                if (rowInit != toUpdate.CurrentInitiative)
                {
                    toUpdate.CurrentInitiative = rowInit;
                    UpdateInitiative();
                }
                //Update hasActed
                if (rowHasActed != toUpdate.HasActedThisRound)
                {
                    toUpdate.HasActedThisRound = rowHasActed;
                }

            }
            if(mainScreen != null)
            {
                if (!mainScreen.RedrawingCombatTable) mainScreen.RedrawCombatTable();
                if (currentFocus != null && name.Equals(currentFocus.Name))
                {
                    if (!mainScreen.RedrawingFocus) mainScreen.RedrawFocus();
                }
            }
            
        }
        public void handle_focus_health_update(object sender, System.EventArgs e)
        {
            
            //only init or has acted can be updated here
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            int colIndex = ((DataGridViewCellEventArgs)e).ColumnIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            if (!currentFocus.Battlegroup)
            {
                HandleHealthUpdateIndividual(rowIndex, colIndex, row);
            }
            else
            {
                HandleHealthUpdateBattleGroup(rowIndex, colIndex, row);
            }
            if (mainScreen != null && !mainScreen.RedrawingHealthLevels) mainScreen.RedrawHealthLevels();

        }
        
        private void HandleHealthUpdateIndividual (int rowIndex, int colIndex, DataGridViewRow row)
        {
            //Retrieve data from event
            String focusName = currentFocus.Name;
            String newHLValue = (string)row.Cells[colIndex].Value;
            String hl = currentFocus.CurrentHealthLevels.ElementAt(colIndex).Key;
            Constants.HealthState oldValue = currentFocus.CurrentHealthLevels.ElementAt(colIndex).Value;

            if (Util.Constants.IsHealthLevelAllowed(newHLValue))
            {
                if (Constants.StringToHealthState(newHLValue) != oldValue)
                {
                    //Update
                    KeyValuePair<String, Util.Constants.HealthState> newPair = new KeyValuePair<string, Constants.HealthState>(hl, Constants.StringToHealthState(newHLValue));
                    currentFocus.CurrentHealthLevels.RemoveAt(colIndex);
                    currentFocus.CurrentHealthLevels.Insert(colIndex, newPair);
                }

            }
            else
            {
                //restore old value
                row.Cells[colIndex].Value = Constants.HealthStateToString(oldValue);
            }
        }

        private void HandleHealthUpdateBattleGroup(int rowIndex, int colIndex, DataGridViewRow row)
        {
            Battlegroup bg = (Battlegroup)currentFocus;
            //Only check current size and magnitude
            if(colIndex == 0 || colIndex == 2)
            {
                //Convert from string
                Boolean needToParseMag = !(row.Cells[0].Value is int);
                int rowMagnitude = 0;
                if (!needToParseMag) rowMagnitude = (int)row.Cells[0].Value;
                Boolean parseSuccesful = needToParseMag ? int.TryParse((string)row.Cells[0].Value, out rowMagnitude) : true;

                Boolean needToParseSize = !(row.Cells[2].Value is int);
                int rowSize = 0;
                if (!needToParseSize) rowSize = (int)row.Cells[2].Value;
                parseSuccesful = parseSuccesful && (needToParseSize ? int.TryParse((string)row.Cells[2].Value, out rowSize) : true);
                if (parseSuccesful)
                {
                    //Change values, size first
                    if(rowSize != bg.CurrentSize)
                    {
                        bg.CurrentSize = rowSize;
                    }
                    if(rowMagnitude != bg.CurrentMagnitude)
                    {
                        if(!(rowMagnitude <= 0)){
                            bg.CurrentMagnitude = rowMagnitude;
                        }
                        else
                        {
                            //If magnitude drops below 0, drop size and restore mag to new max
                            bg.CurrentSize--;
                            if(bg.CurrentSize <= 0)
                            {
                                //Set to 0 for cleanup step
                                bg.CurrentMagnitude = 0;
                            }
                            else
                            {
                                bg.CurrentMagnitude = bg.GetCurrentMaxMagnitude();
                            }
                        }
                         
                    }
                    
                }

                
            }
        }
        public void handle_focus_effects_update(object sender, System.EventArgs e)
        {
            
            //only init or has acted can be updated here
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            //Retrieve data from event
            String name = (String)row.Cells[0].Value;
            String description = (String)row.Cells[1].Value;
            Boolean needToParse = !(row.Cells[2].Value is int);
            int turnsRemaining = 0;
            if (!needToParse) turnsRemaining = (int)row.Cells[2].Value;
            Boolean parseSuccesful = needToParse ? int.TryParse((string)row.Cells[2].Value, out turnsRemaining) : true;
            if (parseSuccesful)
            {

                Effect toUpdate = currentFocus.CurrentEffects[rowIndex];
                //Effect toUpdate = currentFocus.GetEffectByName(name);

                //Name
                if (name != toUpdate.Name)
                {
                    toUpdate.Name = name;
                    
                }
                //Description
                if (description != toUpdate.Description)
                {
                    toUpdate.Description = description;
                }
                //Turns Remaining
                if(toUpdate.Temporary && turnsRemaining != toUpdate.RemainingTurns)
                {
                    toUpdate.RemainingTurns = turnsRemaining;
                }

            }
            if (mainScreen != null)
            {
                //Let the view update the focus character
                if(!mainScreen.RedrawingFocus) mainScreen.RedrawFocus();
            }
        }
        public void handle_delete_button_clicked(object sender, System.EventArgs e)
        {
            if (mainScreen != null)
            {
                
                int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
                int colIndex = ((DataGridViewCellEventArgs)e).ColumnIndex;
                if (colIndex == 4)
                {
                    DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

                    //Retrieve data from event
                    String name = (String)row.Cells[1].Value;
                    Character toUpdate = currentCombat.GetCharacter(name); //check if present
                    if (toUpdate != null && !mainScreen.DeleteWindowOpen)
                    {
                        mainScreen.DeleteWindowOpen = true;
                        DeleteConfirmation delConfirm = new DeleteConfirmation(this, name);
                        delConfirm.Show();

                    }
                }
            }

        }
        #endregion Event Handling
    }
}
