using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Carbohydrates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int CarbCalories(int carbGrams)
        {
            return carbGrams * 4;
        }

        public int FatCalories(int fatGrams)
        {
            return fatGrams * 9;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int fatGrams, carbGrams, calFromCarbs, calFromFat;

            // Get fat Grams
            if (int.TryParse(fatGramsTextBox.Text, out fatGrams))
            {
                // Use method to return appropriate value
                calFromFat = FatCalories(fatGrams);

                // Display fat calories
                fatCaloriesTextBox.Text = calFromFat.ToString();

                // Get carb grams
                if (int.TryParse(carbGramsTextBox.Text, out carbGrams))
                {
                    // Use method to return appropriate value
                    calFromCarbs = CarbCalories(carbGrams);

                    // Display carb calories
                    carbCaloriesTextBox.Text = calFromCarbs.ToString();
                }
                else
                {
                    // Display error message
                    MessageBox.Show("Enter a valid integer for Carb Grams");
                }
            }
            else
            {
                // Display error message
                MessageBox.Show("Enter a valid integer for Fat Grams");
            }
        }
    }
}
