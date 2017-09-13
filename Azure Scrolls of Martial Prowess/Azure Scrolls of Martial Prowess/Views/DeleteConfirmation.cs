using Azure_Scrolls_of_Martial_Prowess.Controllers;
using Azure_Scrolls_of_Martial_Prowess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure_Scrolls_of_Martial_Prowess.Views
{
    public partial class DeleteConfirmation : Form
    {
        private CombatController cc;
        private string toDelete;
        public DeleteConfirmation()
        {
            InitializeComponent();
        }

        public DeleteConfirmation(CombatController cc, string toDelete)
        {
            InitializeComponent();
            label_Name.Text = toDelete;
            this.cc = cc;
            this.toDelete = toDelete;
            
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            //Remove and re-enable the window
            cc.DeleteCharacter(toDelete);
            //Close window
            this.Close();
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
