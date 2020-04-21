using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        Random rng;
        Wallet wallet;
        public int tempeture;
        public Customer(Random rng, int tempeture)
        {
            this.tempeture = tempeture;
            this.rng = rng;
        }
    }   

}
