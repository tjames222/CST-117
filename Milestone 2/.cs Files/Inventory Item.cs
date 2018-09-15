using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Inventory_Item
    {
        // Declaring properties
        private string _item; // Name of item
        private int _quantity; // Quantity of item
        private string _group; // Group of item
        private int _modelNum; // Model number of item
        private decimal _price; // Price of item

        // Constructor
        public Inventory_Item()
        {
            _item = "";
            _quantity = 0;
            _group = "";
            _modelNum = 0;
            _price = 0m;
        }

        // Item property
        public string Item
        {
            get { return _item; }
            set { _item = value; }
        }

        // Quantity property
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // Group property
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        // Model Number property
        public int ModelNum
        {
            get { return _modelNum; }
            set { _modelNum = value; }
        }

        // Price Property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
