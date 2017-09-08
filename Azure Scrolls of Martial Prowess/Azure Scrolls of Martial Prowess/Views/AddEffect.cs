
using System;
using System.Collections.Generic;

using System.Windows.Forms;
using Azure_Scrolls_of_Martial_Prowess.Controllers;
using Azure_Scrolls_of_Martial_Prowess.Models;

namespace Azure_Scrolls_of_Martial_Prowess.Views
{
    public partial class AddEffect : Form
    {

        private CombatController combatController;

        public AddEffect()
        {
            InitializeComponent();
        }

        public AddEffect(CombatController cc)
        {
            InitializeComponent();
            this.combatController = cc;
        }


        private void checkBox_AddEffect_isTemporary_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox isTempBox = (CheckBox)sender;
            if (isTempBox.Checked)
            {
                //Show duration
                numericUpDown_AddEffect_Duration.Enabled = true;
                numericUpDown_AddEffect_Duration.Visible = true;
            }
            else
            {
                //Hide duration
                numericUpDown_AddEffect_Duration.Enabled = true;
                numericUpDown_AddEffect_Duration.Visible = true;
            }
        }

        private void button_AddEffect_Click(object sender, EventArgs e)
        {
            //Collect Data
            String name = textBox_AddEffect_Name.Text;
            String description = textBox_AddEffect_Description.Text;
            int remainingTurns;
            if (checkBox_AddEffect_isTemporary.Checked)
            {
                remainingTurns = (int) numericUpDown_AddEffect_Duration.Value;
            }
            else
            {
                remainingTurns = -1;
            }
            //Create Effect
            Effect toAdd = new Effect(name, description, checkBox_AddEffect_isTemporary.Checked, remainingTurns);
            combatController.AddEffectToFocus(toAdd);
            //Close window
            this.Close();
        }
    }
}
