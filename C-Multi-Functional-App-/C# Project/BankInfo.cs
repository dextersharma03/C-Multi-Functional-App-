using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class BankInfo
    {

        private decimal _balance;                   // Backing Field

        public BankInfo()                        // Default Constructor
        {
            _balance = 0m;
        }

        public BankInfo(decimal startingBalance) // Binding to a decimal Constructor
        {
            _balance = startingBalance;
        }

        public decimal Balance                      // Balance property (read-only)
        {
            get { return _balance; }
        }

        public void Deposit(decimal amount)         // Deposit method
        {
            _balance += amount;
        }

        public void Deposit(int amount)             // overloaded int Deposit method 
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)        // Withdraw method
        {
            _balance -= amount;
        }
    }
}
