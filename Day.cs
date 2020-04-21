using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public string dayOfWeek;
        Random rng;

        public Day(string dayOfWeekPassed)
        {
            customers = new List<Customer>();
            dayOfWeek = dayOfWeekPassed;
        }


        public void GenerateCustomers()
        {
            //gen a number
            int randomNumber = rng.Next();
            //use that number to run a for loop for value of the number
            for (int i = 0; i > 100; i++)
            {
                customers.Add(new Customer(rng));
            }
            //in the for loop add new customer objects into the customers list like I am doing on the game class for days
        }
    }

    
}
