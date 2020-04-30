using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class CellphoneData
    {
        string _brand;                  // The phone's brand
        string _model;                  // The phone's model
        decimal _price;                 // Retail price

        public CellphoneData()              // Constructor
        { 
            _brand = "";                // Private Backing fields
            _model = "";
            _price = 0m;
        }

        public string Brand             // Brand property - Method 1 to declare
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model             // Brand property - Method 1 to declare
        {
            get;
            set;
        }

        public decimal Price { get; set; }// Brand property - Method 1 to declare

    }
}
