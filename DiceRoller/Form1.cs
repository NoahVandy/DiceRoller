//this is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{ 
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            int sides = (int)numUpDown_sides.Value + 1;
            Dice d1 = new Dice(sides);
            Dice d2 = new Dice(sides);

            int d1Value = d1.rollDice();
            int d2Value = d2.rollDice();

            lbl_d1Value.Text = d1Value.ToString();
            lbl_d2Value.Text = d2Value.ToString();


            if (d1Value + d2Value == 2)
            {
                MessageBox.Show("it took " + count + " tries for you to roll snake eyes");
                count = 0;
            }
            else
            {
                count++;
            }
            lbl_numOfTries.Text = "Number of tries: " + count.ToString();
            
        }

        private void numUpDown_sides_ValueChanged(object sender, EventArgs e)
        {
            int sides = (int)numUpDown_sides.Value;

            lbl_numOfSides.Text = "Number of sides: " + sides.ToString();
        }
    }
}
