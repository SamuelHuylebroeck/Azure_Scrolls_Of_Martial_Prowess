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

namespace Azure_Scrolls_of_Martial_Prowess
{
    public partial class MainScreen : Form
    {
        private CombatController combatController;

        public MainScreen()
        {
            InitializeComponent();
            combatController = new CombatController();
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


        private void Update_Combat_Table()
        {


        }
    }

}
