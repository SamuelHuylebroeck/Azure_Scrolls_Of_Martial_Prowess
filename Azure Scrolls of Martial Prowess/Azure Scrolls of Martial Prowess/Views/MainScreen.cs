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
            dataGridView_CombatTable.Rows.Clear();
            UpdateCombatTable();
        }

        private void Button_AddCharacter_Click(object sender, EventArgs e)
        {
            Form toAdd = new AddCharacter(combatController);
            toAdd.Show();
        }


        public void UpdateCombatTable()
        {
            
            foreach (KeyValuePair<int,String> participant in combatController.initiativeList) {
                Object[] values = { participant.Key, participant.Value, "insert description here", false };
                dataGridView_CombatTable.Rows.Add(values);
                dataGridView_CombatTable.CellEndEdit += new DataGridViewCellEventHandler(combatController.handle_init_list_update);
            }
        }

    }

}
