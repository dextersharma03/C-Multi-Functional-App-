using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Automotive_Car
    {
        string _Make;                  // The phone's brand
        string _Model;                  // The phone's model
        string _Year;                 // Retail price

        public Automotive_Car()              // Constructor
        {
            _Make = "";                // Private Backing fields
            _Model = "";
            _Year = "";
        }

        public string Make             // Make property - Method 1 to declare
        {
            get { return _Make; }
            set { _Make = value; }
        }

        public string Model             // Model property - Method 1 to declare
        {
            get;
            set;
        }

        public string Year { get; set; }// Year property - Method 1 to declare
    }
}
