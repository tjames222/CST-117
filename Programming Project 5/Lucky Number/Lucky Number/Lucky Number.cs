using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lucky_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load years into combo box
            for (int i = 1940; i <= 2050; i++)
            {
                yearComboBox.Items.Add(i);
            }

            // Load months into combo box
            monthComboBox.Items.Add("January");
            monthComboBox.Items.Add("February");
            monthComboBox.Items.Add("March");
            monthComboBox.Items.Add("April");
            monthComboBox.Items.Add("May");
            monthComboBox.Items.Add("June");
            monthComboBox.Items.Add("July");
            monthComboBox.Items.Add("August");
            monthComboBox.Items.Add("September");
            monthComboBox.Items.Add("October");
            monthComboBox.Items.Add("November");
            monthComboBox.Items.Add("December");

            // Load Colors into combo box
            colorComboBox.Items.Add("Red");
            colorComboBox.Items.Add("Green");
            colorComboBox.Items.Add("Blue");
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayComboBox.Items.Clear();

            // Load proper amount of days based on month selected
            if (monthComboBox.SelectedItem.ToString() == "January" || monthComboBox.SelectedItem.ToString() == "March" ||
                monthComboBox.SelectedItem.ToString() == "May" || monthComboBox.SelectedItem.ToString() == "July" ||
                monthComboBox.SelectedItem.ToString() == "August" || monthComboBox.SelectedItem.ToString() == "October" ||
                monthComboBox.SelectedItem.ToString() == "December")
            {
                //dayComboBox.Items.Clear();

                for (int i = 1; i <= 31; i++)
                {
                    dayComboBox.Items.Add(i);
                }
            }
            else if (monthComboBox.SelectedItem.ToString() == "April" || monthComboBox.SelectedItem.ToString() == "June" ||
                monthComboBox.SelectedItem.ToString() == "September" || monthComboBox.SelectedItem.ToString() == "November")
            {
                //dayComboBox.Items.Clear();

                for (int i = 1; i <= 30; i++)
                {
                    dayComboBox.Items.Add(i);
                }
            }

            // Test for leap year and load days for february with proper days
            else if (monthComboBox.SelectedItem.ToString() == "February" && yearComboBox.SelectedItem.ToString() == "1940" || yearComboBox.SelectedItem.ToString() == "1944" || 
                yearComboBox.SelectedItem.ToString() == "1948" || yearComboBox.SelectedItem.ToString() == "1952" || yearComboBox.SelectedItem.ToString() == "1956" ||
                yearComboBox.SelectedItem.ToString() == "1960" || yearComboBox.SelectedItem.ToString() == "1964" || yearComboBox.SelectedItem.ToString() == "1968" ||
                yearComboBox.SelectedItem.ToString() == "1972" || yearComboBox.SelectedItem.ToString() == "1976" || yearComboBox.SelectedItem.ToString() == "1980" ||
                yearComboBox.SelectedItem.ToString() == "1984" || yearComboBox.SelectedItem.ToString() == "1988" || yearComboBox.SelectedItem.ToString() == "1992" ||
                yearComboBox.SelectedItem.ToString() == "1996" || yearComboBox.SelectedItem.ToString() == "2000" || yearComboBox.SelectedItem.ToString() == "2004" ||
                yearComboBox.SelectedItem.ToString() == "2008" || yearComboBox.SelectedItem.ToString() == "2012" || yearComboBox.SelectedItem.ToString() == "2016" ||
                yearComboBox.SelectedItem.ToString() == "2020" || yearComboBox.SelectedItem.ToString() == "2024" || yearComboBox.SelectedItem.ToString() == "2028" ||
                yearComboBox.SelectedItem.ToString() == "2032" || yearComboBox.SelectedItem.ToString() == "2036" || yearComboBox.SelectedItem.ToString() == "2040" ||
                yearComboBox.SelectedItem.ToString() == "2044" || yearComboBox.SelectedItem.ToString() == "2048")
            {
                //dayComboBox.Items.Clear();

                for (int i = 1; i <= 29; i++)
                {
                    dayComboBox.Items.Add(i);
                }
            }
            else
            {
                //dayComboBox.Items.Clear();

                for (int i = 1; i <= 28; i++)
                {
                    dayComboBox.Items.Add(i);
                }
            }
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            // Creates an instance of a new form
            ResultsForm results = new ResultsForm();

            // Variables for day and year
            int day = int.Parse(dayComboBox.SelectedItem.ToString());
            int year = int.Parse(yearComboBox.SelectedItem.ToString());
            string color = colorComboBox.Text;

            // Math for Lucky Number
            int luckyNum = (year - day) / 5;

            // Set lucky number text
            results.numberLabel.Text = luckyNum.ToString();

            // Set color of square
            if (color == "Red")
            {
                results.square.BackColor = Color.Red;
            }
            else if (color == "Blue")
            {
                results.square.BackColor = Color.Blue;
            }
            else if (color == "Green")
            {
                results.square.BackColor = Color.Green;
            }

            // Set color of label
            if (color == "Red")
            {
                results.numberLabel.BackColor = Color.Red;
            }
            else if (color == "Blue")
            {
                results.numberLabel.BackColor = Color.Blue;
            }
            else if (color == "Green")
            {
                results.numberLabel.BackColor = Color.Green;
            }

            results.ShowDialog();
        }
    }
}
