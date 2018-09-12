using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare varibles to be used
        int dieSidesIn;
        int count;

        // Create two dice objects
        Dice leftDiceObject = new Dice();
        Dice rightDiceObject = new Dice();

        // Controller for snake eyes  
        int rollStopper = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // loop to roll dice each time and set the die face number
                if (rollStopper <= 0)
                {
                    // Take text from text box and convert to int
                    dieSidesIn = int.Parse(numSides.Text);

                    if (dieSidesIn > 20 || dieSidesIn < 4)
                    {
                        MessageBox.Show("Please enter a value between 4 and 20!");
                        this.Close();
                    }

                    // Set dieSides
                    leftDiceObject.DieSides = dieSidesIn;
                    rightDiceObject.DieSides = dieSidesIn;

                    // Roll the left Dice
                    leftDiceObject.RollL();

                    // Display left die result
                    leftDie.Text = leftDiceObject.DieSideL.ToString();

                    // Roll right die
                    rightDiceObject.RollR();

                    // Display right die result
                    rightDie.Text = rightDiceObject.DieSideR.ToString();

                    
                }
                // increase count each time the button is clicked
                count++;

                // Tests if snake eyes is true
                if (leftDiceObject.DieSideL == 1 && rightDiceObject.DieSideR == 1)
                {
                    rollStopper = 1;
                }
                
                // Displays message to user when snake eyes is hit
                if (rollStopper == 1)
                {
                    MessageBox.Show("It took " + count + " rolls to get snake eyes!");
                    this.Close();
                }  
            }
            catch
            {
                MessageBox.Show("Numeric value between 4 and 20 only!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
