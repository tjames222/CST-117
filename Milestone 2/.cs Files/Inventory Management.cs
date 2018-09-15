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
    public partial class inventoryManagement : Form
    {
        // List to hold inventory items
        public List<Inventory_Item> inventoryList1 = new List<Inventory_Item>();

        public inventoryManagement()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void quantityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fixes the duplicate item adding problem
            inventoryList1.Clear();

            // Create an instance of the Add Item Form
            Add_Item addItemForm = new Add_Item(this);

            addItemForm.ShowDialog();

            foreach (var newItem in inventoryList1)
            {
                ListViewItem row = new ListViewItem(newItem.Quantity.ToString());

                row.SubItems.Add(newItem.Item);
                row.SubItems.Add(newItem.Group);
                row.SubItems.Add(newItem.ModelNum.ToString());
                row.SubItems.Add(newItem.Price.ToString("n2"));
                InventoryListView.Items.Add(row);
            }
        }
    }
}