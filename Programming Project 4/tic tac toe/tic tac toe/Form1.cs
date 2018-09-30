using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        // Random number generator
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNG_Click(object sender, EventArgs e)
        {

            // Clear text box
            labelWinner.Text = "";

            const string x = "x";
            const string o = "o";

            // Declare constants for columns and rows
            const int ROWS = 3;
            const int COLS = 3;

            // Declare two dimensional array
            int[,] labels = new int[ROWS, COLS];

            // Fill the Array with random numbers
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    labels[row, col] = rand.Next(2);
                }
            }

            // Display array contents
            // Change number to X or O
            if (labels[0,0] == 0)
            {
                label00.Text = x;
            }
            else
            {
                label00.Text = o;
            }

            if (labels[0, 1] == 0)
            {
                label01.Text = x;
            }
            else
            {
                label01.Text = o;
            }

            if (labels[0, 2] == 0)
            {
                label02.Text = x;
            }
            else
            {
                label02.Text = o;
            }

            if (labels[1, 0] == 0)
            {
                label10.Text = x;
            }
            else
            {
                label10.Text = o;
            }

            if (labels[1, 1] == 0)
            {
                label11.Text = x;
            }
            else
            {
                label11.Text = o;
            }

            if (labels[1, 2] == 0)
            {
                label12.Text = x;
            }
            else
            {
                label12.Text = o;
            }

            if (labels[2, 0] == 0)
            {
                label20.Text = x;
            }
            else
            {
                label20.Text = o;
            }

            if (labels[2, 1] == 0)
            {
                label21.Text = x;
            }
            else
            {
                label21.Text = o;
            }

            if (labels[2, 2] == 0)
            {
                label22.Text = x;
            }
            else
            {
                label22.Text = o;
            }

            // Display Winner
            if (x == label00.Text && x == label01.Text && x == label02.Text || x == label10.Text && x == label11.Text && x == label12.Text ||
                x == label20.Text && x == label21.Text && x == label22.Text || x == label20.Text && x == label11.Text && x == label02.Text ||
                x == label00.Text && x == label11.Text && x == label22.Text || x == label00.Text && x == label10.Text && x == label20.Text ||
                x == label01.Text && x == label11.Text && x == label21.Text || x == label02.Text && x == label12.Text && x == label22.Text) 
            {
                labelWinner.Text = "PLAYER X IS THE WINNER!";
            }
            else if (o == label00.Text && o == label01.Text && o == label02.Text || o == label10.Text && o == label11.Text && o == label12.Text ||
                o == label20.Text && o == label21.Text && o == label22.Text || o == label20.Text && o == label11.Text && o == label02.Text ||
                o == label00.Text && o == label11.Text && o == label22.Text || o == label00.Text && o == label10.Text && o == label20.Text ||
                o == label01.Text && o == label11.Text && o == label21.Text || o == label02.Text && o == label12.Text && o == label22.Text)
            {
                labelWinner.Text = "PLAYER O IS THE WINNER!";
            }
            else
            {
                labelWinner.Text = "CATS GAME!!";
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
