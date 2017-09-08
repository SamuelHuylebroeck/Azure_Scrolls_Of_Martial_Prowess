﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure_Scrolls_of_Martial_Prowess.Controllers;
using Azure_Scrolls_of_Martial_Prowess.Views;
using Azure_Scrolls_of_Martial_Prowess.Models;
using Azure_Scrolls_of_Martial_Prowess.Util;
using Azure_Scrolls_of_Martial_Prowess;

namespace Azure_Scrolls_of_Martial_Prowess
{
    public partial class MainScreen : Form
    {
        private CombatController combatController;
        private Dictionary<String, Constants.Characteristic> updateHandlerMapping;

        public MainScreen()
        {
            InitializeComponent();
            updateHandlerMapping = new Dictionary<String, Constants.Characteristic>();
            combatController = new CombatController();
            combatController.RegisterMainScreen(this);

            updateHandlerMapping.Add(numericUpDown_Focus_Initiative.Name, Constants.Characteristic.INIT);
            numericUpDown_Focus_Initiative.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(numericUpDown_Focus_PersonalEssence.Name, Constants.Characteristic.PSE);
            numericUpDown_Focus_PersonalEssence.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(numericUpDown_Focus_PeripheralEssence.Name, Constants.Characteristic.PRE);
            numericUpDown_Focus_PeripheralEssence.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(numericUpDown_Focus_Willpower.Name, Constants.Characteristic.WP);
            numericUpDown_Focus_Willpower.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(comboBox_Focus_Anima.Name, Constants.Characteristic.A);
            numericUpDown_Focus_Onslaught.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(numericUpDown_Focus_Onslaught.Name, Constants.Characteristic.O);

        }



        #region RedrawFunctions
        public void RedrawCombatTable()
        {
            dataGridView_CombatTable.Rows.Clear();
            foreach (KeyValuePair<int, String> initNamePair in combatController.initiativeList)
            {
                Character participant = combatController.GetCharacter(initNamePair.Value);
                Object[] values = { initNamePair.Key, initNamePair.Value, participant.GetShortDescription(), participant.HasActedThisRound };
                dataGridView_CombatTable.Rows.Add(values);
            }
            dataGridView_CombatTable.CellEndEdit += new DataGridViewCellEventHandler(combatController.handle_init_list_update);
            dataGridView_CombatTable.CellDoubleClick += new DataGridViewCellEventHandler(handle_new_focus);

        }

        public void RedrawFocus()
        {
            Character currentFocus = combatController.currentFocus;
            //Fields
            if (currentFocus != null)
            {
                textBox_name.Text = currentFocus.Name;
                Type.Text = currentFocus.Type;
                numericUpDown_Focus_Initiative.Value = currentFocus.CurrentInitiative;
                numericUpDown_Focus_PersonalEssence.Value = currentFocus.CurrentPersonalEssence;
                numericUpDown_Focus_PeripheralEssence.Value = currentFocus.CurrentPeripheralEssence;
                numericUpDown_Focus_Willpower.Value = currentFocus.CurrentWillPower;
                numericUpDown_Focus_Onslaught.Value = currentFocus.CurrentOnslaught;
                comboBox_Focus_Anima.SelectedValue = currentFocus.CurrentAnimaLevel;

                //Health
                RedrawHealthLevels();
                //Effects
                RedrawEffects();
            }

        }

        private void RedrawHealthLevels()
        {
            Character currentFocus = combatController.currentFocus;
            //Adjust table
            int nrOfColumns = currentFocus.CurrentHealthLevels.Count;

            dataGridView_Focus_HealthLevels.Rows.Clear();
            dataGridView_Focus_HealthLevels.Columns.Clear();
            List<String> healthValuesAsString = new List<String>();

            //set row width and columnheight
            foreach (KeyValuePair<String, Constants.HealthState> kvp in currentFocus.CurrentHealthLevels)
            {
                dataGridView_Focus_HealthLevels.Columns.Add(kvp.Key, kvp.Key);
                healthValuesAsString.Add(Constants.HealthStateToString(kvp.Value));
            }
            if (!currentFocus.Battlegroup)
            {
                dataGridView_Focus_HealthLevels.Rows.Add(healthValuesAsString.ToArray());
            }
            else
            {
                //Current size and magnitude
            }
            
            dataGridView_Focus_HealthLevels.CellEndEdit += new DataGridViewCellEventHandler(combatController.handle_focus_health_update);
        }

        private void RedrawEffects()
        {
            Character currentFocus = combatController.currentFocus;
            dataGridView_Focus_Effects.Rows.Clear();
            
            foreach (Effect eff in currentFocus.CurrentEffects)
            {
                String turnsRemaining = "-1";
                if (eff.Temporary)
                {
                    turnsRemaining = "" + eff.RemainingTurns;
                }
                Object[] values = { eff.Name, eff.Description, turnsRemaining };
                dataGridView_Focus_Effects.Rows.Add(values);
            }
            dataGridView_Focus_Effects.CellEndEdit += new DataGridViewCellEventHandler(combatController.handle_focus_effects_update);
        }

        #endregion RedrawFunctions

        #region EventHandling
        private void handle_new_focus(object sender, System.EventArgs e)
        {
            //Retrieve character
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            //Retrieve data from event
            String name = (String)row.Cells[1].Value;
            Character newFocus = combatController.currentCombat.GetCharacter(name);
            //Update focus
            combatController.UpdateFocus(newFocus);
        }

        public void handle_focus_character_update_numericUpDown(object sender, System.EventArgs e)
        {
            if (combatController.currentFocus != null)
            {
                //Code
                String controlName = ((Control)sender).Name;
                Constants.Characteristic code;
                bool present = updateHandlerMapping.TryGetValue(controlName, out code);
                //Value
                int newValue = (int)((NumericUpDown)sender).Value;
                if (present) combatController.UpdateFocusCharacter(code, newValue);
            }
        }

        public void handle_focus_character_update_text(object sender, System.EventArgs e)
        {
            if (combatController.currentFocus != null)
            {
                //Code
                String controlName = ((Control)sender).Name;
                Constants.Characteristic code;
                bool present = updateHandlerMapping.TryGetValue(controlName, out code);
                //Value
                String newValue = (String)((TextBox)sender).Text;
                if (present) combatController.UpdateFocusCharacter(code, newValue);
            }

        }

        public void handle_focus_character_update_comboBox(object sender, System.EventArgs e)
        {
            if (combatController.currentFocus != null)
            {
                //Code
                String controlName = ((Control)sender).Name;
                Constants.Characteristic code;
                bool present = updateHandlerMapping.TryGetValue(controlName, out code);
                //Value
                object newValue = ((ComboBox)sender).SelectedValue;
                if (present) combatController.UpdateFocusCharacter(code, newValue);
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            RedrawCombatTable();
        }

        private void Button_NextRound_Click(object sender, EventArgs e)
        {
            combatController.NextRound();
        }

        private void Button_AddCharacter_Click(object sender, EventArgs e)
        {
            Form toAdd = new AddCharacter(combatController);
            toAdd.Show();
        }

        private void Button_AddEffect_Click(object sender, EventArgs e)
        {
            Form toAdd = new AddEffect(combatController);
            toAdd.Show();
        }
        private void Button_Refresh_Character_Click(object sender, EventArgs e)
        {
            RedrawFocus();
        }

        private void checkBox_Focus_KeepOnslaught_CheckedChanged(object sender, EventArgs e)
        {
            if(combatController.currentFocus != null)
            {
                Boolean fieldValue = ((CheckBox)sender).Checked;
                Boolean oldValue = combatController.currentFocus.KeepOnslaughtOnAct;
                if(fieldValue != oldValue)
                {
                    combatController.currentFocus.KeepOnslaughtOnAct = fieldValue;
                }
            }
        }

        #endregion EventHandling

        private void numericUpDown_Focus_Onslaught_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
