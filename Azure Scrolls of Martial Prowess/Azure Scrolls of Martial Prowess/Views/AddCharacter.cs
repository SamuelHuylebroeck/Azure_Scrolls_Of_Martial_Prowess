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
using Azure_Scrolls_of_Martial_Prowess.Models;

namespace Azure_Scrolls_of_Martial_Prowess.Views
{
    public partial class AddCharacter : Form
    {

        private CombatController combatController;
        public AddCharacter()
        {
            InitializeComponent();
        }

        public AddCharacter(CombatController cc)
        {
            InitializeComponent();
            this.combatController = cc;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Create Template
            String name = textBox_name.Text;
            String type = textBox_type.Text;

            int periE = (int) numericUpDown_peripheral.Value;
            int persE = (int)numericUpDown_personal.Value;
            int willpower = (int)numericUpDown_willpower.Value;

            CharacterTemplate template = new CharacterTemplate(type, willpower, periE, persE);
            Character newChar = new Character(name, template);
            combatController.AddCharacter(newChar);
            combatController.UpdateFocus(newChar);
            this.Close();
        }
    }
}
