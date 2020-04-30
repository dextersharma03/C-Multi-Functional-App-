using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class ServiceRequest
    {
        decimal _Parts;                  // The phone's brand
        decimal _Labour;                  // The phone's model
        decimal _Tax;                 // Retail price

        public ServiceRequest()              // Constructor
        {
            _Parts = 0m;                // Private Backing fields
            _Labour = 0m;
            _Tax = 0m;
        }

        public decimal Parts             // Parts property - Method 1 to declare
        {
            get { return _Parts; }
            set { _Parts = value; }
        }

        public decimal Labour             // Model property - Method 1 to declare
        {
            get;
            set;
        }

        public decimal Tax { get; set; }// Price property - Method 1 to declare
    }
}
