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
    public partial class Edit_Window : Form
    {
        // Allows form cross communication
        InventoryManagement originalForm;

        // Temporary holding places
        decimal price;
        int quantity;
        int modelNum;

        

        public Edit_Window(InventoryManagement incomingForm) // allows form cross communication
        {
            originalForm = incomingForm; // allows form cross communication
            InitializeComponent();

        }

        public void GetItemData(Inventory_Item edit)
        {
            // Get the item
            edit.Item = itemTextBoxEdit.Text;

            // Get the quantity of item
            // Test for int in
            if (int.TryParse(quantityTextBoxEdit.Text, out quantity))
            {
                edit.Quantity = quantity;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid quantity");
            }

            // Get the group of item
            edit.Group = groupTextBoxEdit.Text;

            // Get model number of item
            // Test for int in
            if (int.TryParse(modelNumTextBoxEdit.Text, out modelNum))
            {
                edit.ModelNum = modelNum;
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid Model Number");
            }

            // Get price of item
            if (decimal.TryParse(priceTextBoxEdit.Text, out price))
            {
                edit.Price = price;
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid Price");
            }
        }

        private void Edit_Window_Load(object sender, EventArgs e)
        {

        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Create a Inventory_Item object
            Inventory_Item myItem = new Inventory_Item(quantity, "t", "t",
                0, 1);

            // Get item data
            GetItemData(myItem);

            // Add the Inventory_Item object to the list
            originalForm.inventoryList1.Add(myItem);

            this.Close();
        }
    }
}

