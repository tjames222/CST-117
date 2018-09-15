using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Add_Item : Form
    {
        // Allows form cross communication
        inventoryManagement originalForm;

        // Temporary holding places
        decimal price;
        int quantity;
        int modelNum;

        public Add_Item(inventoryManagement incomingForm) // allows form cross communication
        {
            originalForm = incomingForm; // allows form cross communication
            InitializeComponent();
        }

        public void GetItemData(Inventory_Item newItem)
        {

            // Get the item
            newItem.Item = itemTextBox.Text;

            // Get the quantity of item
            // Test for int in
            if (int.TryParse(quantityTextBox.Text, out quantity))
            {
                newItem.Quantity = quantity;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid quantity");
            }

            // Get the group of item
            newItem.Group = groupTextBox.Text;

            // Get model number of item
            // Test for int in
            if (int.TryParse(modelNumTextBox.Text, out modelNum))
            {
                newItem.ModelNum = modelNum;
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid Model Number");
            }

            // Get price of item
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                newItem.Price = price;
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid Price");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        public void addItemButton_Click(object sender, EventArgs e)
        {
            // Create a Inventory_Item object
            Inventory_Item myItem = new Inventory_Item();

            // Get item data
            GetItemData(myItem);

            // Add the Inventory_Item object to the list
            originalForm.inventoryList1.Add(myItem);

            this.Close();
        }
    }
}
