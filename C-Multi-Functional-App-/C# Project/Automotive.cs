using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Automotive_Customer
    {
        string _Name;                  // The phone's brand
        string _Address;                  // The phone's model
        string _Phone;                 // Retail price

        public Automotive_Customer()              // Constructor
        {
            _Name = "";                // Private Backing fields
            _Address = "";
            _Phone = "";
        }

        public string Name             // Name property - Method 1 to declare
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Address             // Model property - Method 1 to declare
        {
            get;
            set;
        }

        public string Phone { get; set; }// Price property - Method 1 to declare

    }
}

