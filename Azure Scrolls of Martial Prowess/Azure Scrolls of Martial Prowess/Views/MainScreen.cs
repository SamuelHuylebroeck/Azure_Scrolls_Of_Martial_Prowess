using System;
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
            updateHandlerMapping.Add(upDown_Focus_Initiative.Name, Constants.Characteristic.INIT);
            upDown_Focus_Initiative.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(upDown_Focus_PersonalEssence.Name, Constants.Characteristic.PSE);
            upDown_Focus_PersonalEssence.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(upDown_Focus_PeripheralEssence.Name, Constants.Characteristic.PRE);
            upDown_Focus_PeripheralEssence.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);
            updateHandlerMapping.Add(upDown_Focus_Willpower.Name, Constants.Characteristic.WP);
            upDown_Focus_Willpower.ValueChanged += new EventHandler(handle_focus_character_update_numericUpDown);

        }

        private void Button_NextRound_Click(object sender, EventArgs e)
        {
            combatController.NextRound();
            dataGridView_CombatTable.Rows.Clear();
            UpdateCombatTable();
        }

        private void Button_AddCharacter_Click(object sender, EventArgs e)
        {
            Form toAdd = new AddCharacter(combatController);
            toAdd.Show();
            UpdateCombatTable();
        }


        public void UpdateCombatTable()
        {
            dataGridView_CombatTable.Rows.Clear();
            foreach (KeyValuePair<int,String> participant in combatController.initiativeList) {
                Object[] values = { participant.Key, participant.Value, "insert description here", false };
                dataGridView_CombatTable.Rows.Add(values);
                dataGridView_CombatTable.CellEndEdit += new DataGridViewCellEventHandler(combatController.handle_init_list_update);
                dataGridView_CombatTable.CellDoubleClick += new DataGridViewCellEventHandler(handle_new_focus);
            }
        }


        public void UpdateFocus(Character newFocus)
        {
            combatController.currentFocus = newFocus;
            RedrawFocus();
        }

        public void RedrawFocus()
        {
            Character currentFocus = combatController.currentFocus;
            //Fields
            textBox_name.Text = currentFocus.Name;
            Type.Text = currentFocus.Type;
            upDown_Focus_Initiative.Value = currentFocus.CurrentInitiative;
            upDown_Focus_PersonalEssence.Value = currentFocus.PersonalEssence;
            upDown_Focus_PeripheralEssence.Value = currentFocus.PeripheralEssence;
            upDown_Focus_Willpower.Value = currentFocus.Willpower;
            comboBox_Focus_Anima.SelectedValue = currentFocus.CurrentAnimaLevel;

            RedrawHealthLevels();
            RedrawEffects();

        }

        private void RedrawHealthLevels()
        {
            Character currentFocus = combatController.currentFocus;
            //Adjust table
            Table_HealthLevels.ColumnCount = currentFocus.CurrentHealthLevels.Count;
            foreach(KeyValuePair<String, String> kvp in currentFocus.CurrentHealthLevels)
            {

            }
        }

        private void RedrawEffects()
        {

        }

        private void handle_new_focus(object sender ,System.EventArgs e) {
            //Retrieve character
            int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
            DataGridViewRow row = ((DataGridView)sender).Rows[rowIndex];

            //Retrieve data from event
            String name = (String)row.Cells[1].Value;
            Character newFocus = combatController.currentCombat.GetCharacter(name);
            //Update focus
            UpdateFocus(newFocus);
        }

        public void handle_focus_character_update_numericUpDown(object sender, System.EventArgs e)
        {
            //Code
            String controlName = ((Control)sender).Name;
            Constants.Characteristic code;
            bool present = updateHandlerMapping.TryGetValue(controlName, out code);
            //Value
            int newValue = (int)((NumericUpDown)sender).Value;
            if(present) combatController.UpdateFocusCharacter(code, newValue);

        }



        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            UpdateCombatTable();
        }


    }

}
