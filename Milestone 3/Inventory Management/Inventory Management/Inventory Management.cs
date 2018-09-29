// Author: Tim James (My Own Work)
// Course: CST-117
// Professor: Smithers
// Date: 9/29/18

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class InventoryManagement : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        // List to hold inventory items
        public List<Inventory_Item> inventoryList1;

        public InventoryManagement()
        {
            InitializeComponent();

            // Add data table and insert columns 
            dataTable = new DataTable();
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Item");
            dataTable.Columns.Add("Group");
            dataTable.Columns.Add("Item #");
            dataTable.Columns.Add("Price");

            // Populate the data table
            FillDataTable(GenerateData());
            dataView = new DataView(dataTable);

            PopListView(dataView);
        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in InventoryListView.SelectedItems)
            {
                InventoryListView.Items.Remove(eachItem);
            }
        }

        private void QuantityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Fixes the duplicate item adding problem
            inventoryList1.Clear();

            foreach (ListViewItem eachItem in InventoryListView.SelectedItems)
            {
                InventoryListView.Items.Remove(eachItem);
            }
            // Create an instance of the Add Item Form
            Edit_Window editItemForm = new Edit_Window(this);

            editItemForm.ShowDialog();

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

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        // Generate Data filling a list
        private List<Inventory_Item> GenerateData()
        {
            inventoryList1 = new List<Inventory_Item>()
            {
                new Inventory_Item(12, "LED Display", "Monitors", 1234, 12),
                new Inventory_Item(12, "LCD Display", "Monitors", 12, 120),
                new Inventory_Item(12, "LED Display", "Monitors", 345, 115),
                new Inventory_Item(12, "OLED Display", "Monitors", 12455, 546),
                new Inventory_Item(12, "Camera", "Cameras", 312354, 789),
                new Inventory_Item(12, "Phone", "phones", 6897, 154),
                new Inventory_Item(12, "Xbox", "Console", 456, 945),
                new Inventory_Item(12, "PS4", "Console", 645785, 522),
            };
            
            return inventoryList1;
        }

    // Transfer Data from list to Datatable
    private void FillDataTable(List<Inventory_Item> inventoryList1)
    {
        foreach (var inven in inventoryList1)
        {
            dataTable.Rows.Add(inven.Quantity, inven.Item, inven.Group, inven.ModelNum, inven.Price);
        }
    }

    // Fill the listview from dataview
    private void PopListView(DataView dataView)
    {
        InventoryListView.Items.Clear();
        foreach (DataRow row in dataView.ToTable().Rows)
        {
            InventoryListView.Items.Add(new ListViewItem(new string[]
            {
                    row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                    row[4].ToString()
            }));
        }
    }

    // Perform Filtering
    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        // Filter by item or group
        dataView.RowFilter = string.Format("Item + Group Like '%{0}%'", 
            searchTextBox.Text);
        
        PopListView(dataView);
    }
}

}
