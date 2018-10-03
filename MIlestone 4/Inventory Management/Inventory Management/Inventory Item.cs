// Author: Tim James (My Own Work)
// Course: CST-117
// Professor: Smithers
// Date: 9/29/18

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
        private int _quantity; // Quantity of item
        private string _item; // Name of item
        private string _group; // Group of item
        private int _modelNum; // Model number of item
        private decimal _price; // Price of item

        // Constructor
        public Inventory_Item(int _quantity, string _item, string _group, int _modelNum, decimal _price)
        {
            this._quantity = _quantity;
            this._item = _item;
            this._group = _group;
            this._modelNum = _modelNum;
            this._price = _price;

            // _quantity = 0;
            // _item = "";
            // _group = "";
            // _modelNum = 0;
            // _price = 0m;
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

