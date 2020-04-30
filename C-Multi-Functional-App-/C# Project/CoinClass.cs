using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Coin_Class
    {
        private string sideUp;              // Field to represent the side facing up;
       

        Random rand = new Random();         // Random Field object 

        public Coin_Class()                  // Constructor
        {
            sideUp = "Heads";
        }

        public void Toss()                  // The toss method simulates tossing the coin.
        {
            if (rand.Next(2) == 0)          // Use a random number to determine// the side of the coin is facing up.// 0 = Heads, 1 = Tails
                sideUp = "Heads";
            else
                sideUp = "Tails";
        }

        public string GetSideUp()           // The GetSideUp method returns the value// of the sideUp field.
        {
            return sideUp;
        }
    }
}
