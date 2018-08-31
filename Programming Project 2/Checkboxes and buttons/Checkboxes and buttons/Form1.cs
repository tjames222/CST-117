using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkboxes_and_buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Items variables
        string armor;
        string backpack;
        string helmet;
        string sword;
        string shield;
        string boots;
        string shoes;
        string axe;
        string bow;

        // Hair Style Variables
        string shortHair;
        string longHair;
        string bald;

        // Check box functionality
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            backpack = " Backpack ";
                
        }

        private void checkBoxArmor_CheckedChanged(object sender, EventArgs e)
        {
            armor = " Armor ";
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void checkBoxHelmet_CheckedChanged(object sender, EventArgs e)
        {
            helmet = " Helmet ";
        }

        private void checkBoxSword_CheckedChanged(object sender, EventArgs e)
        {
            sword = " Sword ";
        }

        private void checkBoxShield_CheckedChanged(object sender, EventArgs e)
        {
            shield = " Shield ";
        }

        private void checkBoxBoots_CheckedChanged(object sender, EventArgs e)
        {
            boots = " Boots ";
        }

        private void checkBoxShoes_CheckedChanged(object sender, EventArgs e)
        {
            shoes = " Shoes ";
        }

        private void checkBoxAxe_CheckedChanged(object sender, EventArgs e)
        {
            axe = " Axe ";
        }

        private void checkBoxBow_CheckedChanged(object sender, EventArgs e)
        {
            bow = " Bow ";
        }

        // Radio Buttons functionality
        private void radioButtonLong_CheckedChanged(object sender, EventArgs e)
        {
            longHair = "Long";
        }

        private void radioButtonBald_CheckedChanged(object sender, EventArgs e)
        {
            bald = "Bald";
        }

        private void radioButtonShort_CheckedChanged(object sender, EventArgs e)
        {
            shortHair = "Short";
        }

        // listView box functionality
        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Create Character button functionality
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxArmor.Checked)
            {
                itemsLabel.Text += armor;
            }
            if (checkBoxBackPack.Checked)
            {
                itemsLabel.Text += backpack;
            }
            if (checkBoxHelmet.Checked)
            {
                itemsLabel.Text += helmet;
            }
            if (checkBoxSword.Checked)
            {
                itemsLabel.Text += sword;
            }
            if (checkBoxShield.Checked)
            {
                itemsLabel.Text += shield;
            }
            if (checkBoxBoots.Checked)
            {
                itemsLabel.Text += boots;
            }
            if (checkBoxShoes.Checked)
            {
                itemsLabel.Text += shoes;
            }
            if (checkBoxAxe.Checked)
            {
                itemsLabel.Text += axe;
            }
            if (checkBoxBow.Checked)
            {
                itemsLabel.Text += bow;
            }
            if (radioButtonShort.Checked)
            {
                hairLabel.Text += shortHair;
            }        
            else if (radioButtonLong.Checked)
            {
                hairLabel.Text += longHair;
            }
            else if (radioButtonBald.Checked)
            {
                hairLabel.Text += bald;
            }

            nameLabel.Text += nameBox.SelectedItem;

        }

        // Clear all button functionality
        private void button1_Click(object sender, EventArgs e)
        {
            itemsLabel.Text = "";
            nameLabel.Text = "";
            hairLabel.Text = "";
        }
    }
}
