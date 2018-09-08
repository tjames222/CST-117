using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_for_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaring Variables for the program
        int count;
        double termIn;
        double multiple1 = 2;
        double multiple2 = 3;
        double multiple3 = 4;
        double totalMul = 0;
        const double div = 4;
        double pi = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get text and convert to int
                termIn = double.Parse(termBox.Text);

                // Calculate the terms
                for (count = 1; count <= termIn; count++) ;  // for loop executes until count is equivelant to termIn
                {
                    if (termIn == 1)
                    {
                        pi = 3.0;
                    }
                    else if (count % 2 == 0)
                    {
                        totalMul = (4 / (multiple1 * multiple2 * multiple3));
                    }
                    else
                    {
                        totalMul = -(4 / ((multiple1 + 2) * (multiple2 + 2) * (multiple3 + 2)));
                    }

                    pi = pi + (totalMul);
                    multiple1 = multiple1 + 2;
                    multiple2 = multiple2 + 2;
                    multiple3 = multiple3 + 2;
                }
                // Display the answer
                answerBox.Text = pi.ToString();
            }
            catch
            {
                // Displays an error message
                MessageBox.Show("Try again. Numeric values only.");
            }
        }
    }
}
