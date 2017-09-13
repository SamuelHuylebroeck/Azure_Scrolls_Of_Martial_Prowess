using Azure_Scrolls_of_Martial_Prowess.Controllers;
using Azure_Scrolls_of_Martial_Prowess.Models.Factories;
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
    public partial class AddCharacterExtensive : Form
    {
        private CombatController combatController;
        public AddCharacterExtensive()
        {
            InitializeComponent();
        }

        public AddCharacterExtensive(CombatController cc)
        {
            InitializeComponent();
            this.combatController = cc;
        }


        private void button_Finish_Click(object sender, EventArgs e)
        {
            //Gather all data
            List<Object> stats = new List<Object>();
            String code = GetCode();
            //name
            stats.Add(textBox_Name.Text);
            //essence and willpower
            stats.Add(decimal.ToInt32(numericUpDown_Essence.Value));
            stats.Add(decimal.ToInt32(numericUpDown_Willpower.Value));
            //Health levels
            stats.Add(CalculateHealthLevels());
            //Battlegroup info
            stats.Add(checkBox_IsBattlegroup.Checked);
            if (checkBox_IsBattlegroup.Checked)
            {
                stats.Add(comboBox_Drill.Text);
                stats.Add(decimal.ToInt32(numericUpDown_Size.Value));
                stats.Add(decimal.ToInt32(numericUpDown_Might.Value));
            }
            //Use factory to create
            ExtensiveCharacterFactory fact = new ExtensiveCharacterFactory();
            Character toAdd = fact.CreateCharacter(code, stats.ToArray());
            //Add to combat and close
            combatController.AddCharacter(toAdd);
            this.Close();
            
        }

        private String GetCode()
        {
            String res = "Error";
            if (radioButton_Mortal.Checked)
            {
                return "Mortal";
            }
            if (radioButton_Dragonblooded.Checked)
            {
                return "Dragonblooded";
            }
            if (radioButton_Lunar.Checked)
            {
                return "Lunar";
            }
            if (radioButton_SolarAbyssal.Checked)
            {
                return "Solar";
            }
            if (radioButton_Spirit.Checked)
            {
                return "Spirit";
            }
            return res;
        }

        private List<String> CalculateHealthLevels()
        {
            List<String> res = new List<String>();
            for(int i =0 ; i < numericUpDown_minus0.Value; i++)
            {
                res.Add("0");
            }
            for (int i = 0; i < numericUpDown_minus1.Value; i++)
            {
                res.Add("-1");
            }
            for (int i = 0; i < numericUpDown_minus2.Value; i++)
            {
                res.Add("-2");
            }
            for (int i = 0; i < numericUpDown_minus3.Value; i++)
            {
                res.Add("-3");
            }
            for (int i = 0; i < numericUpDown_minus4.Value; i++)
            {
                res.Add("-4");
            }
            res.Add("Inc");
            return res;
        }

        private void checkBox_IsBattlegroup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IsBattlegroup.Checked)
            {
                //Show battlegroup options
                label_size.Show();
                numericUpDown_Size.Show();
                numericUpDown_Size.Enabled = true;
                label_Drill.Show();
                comboBox_Drill.Show();
                comboBox_Drill.Enabled = true;
                label_Might.Show();
                numericUpDown_Might.Show();
                numericUpDown_Might.Enabled = true;
            }
            else
            {
                //Hide battlegroup options
                label_size.Hide();
                numericUpDown_Size.Hide();
                numericUpDown_Size.Enabled = false;
                label_Drill.Hide();
                comboBox_Drill.Hide();
                comboBox_Drill.Enabled = false;
                label_Might.Hide();
                numericUpDown_Might.Hide();
                numericUpDown_Might.Enabled = false;
            }
        }
    }
}
