using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace W4Exercise6
{
    public partial class Form1 : Form
    {
        // declare new objects - likely the wrong place for this
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare count variable
            int count = 0;

            // set dice sides based on user input
            if (Convert.ToInt16(userInput.Text) >= 4
                && Convert.ToInt16(userInput.Text) <= 20)
            {
                dice1.setSides(Convert.ToInt16(userInput.Text));
                dice2.setSides(Convert.ToInt16(userInput.Text));
            }
            else
            {
                MessageBox.Show("Enter a number between 4 and 20!");
            }

            while ((dice1.getFace() != 1) && (dice2.getFace() != 1))
            {
                // roll dice
                dice1.roll(dice1.getSides());
                dice2.roll(dice2.getSides());

                // assign result of roll to Form1 display label.
                result1.Text = dice1.getFace().ToString();
                result2.Text = dice2.getFace().ToString();

                // update count variable
                count++;
            }

            MessageBox.Show("It took "
                + count.ToString()
                + " attempts to roll snake eyes");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result1.Text = "6";
            result2.Text = "5";
            dice1.setFace(6);
            dice2.setFace(5);
        }
    }
}
