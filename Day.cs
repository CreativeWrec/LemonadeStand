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

        public Day(string dayOfWeekPassed, Random random)
        {
            rng = random;
            weather = new Weather(rng);
            customers = new List<Customer>();
            dayOfWeek = dayOfWeekPassed;
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather is " + weather.condition + "and Today's high is" + weather.tempurture);
            Console.ReadLine();
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

        public void StartDay(Player player)
        {   

            foreach(Customer customer in customers)
            {
                bool decision = customer.MakeBuyChoice(weather, player.recipe);
                {
                    if (decision = true)
                    {
                       cupsLeftInPitcher--, 
                       priceOfCup++; 
                    }
                    else if (decision = false)
                    {
                        continue;
                    }
                }

            }

            //loop over the list of customers
            //inside the loop call the cusotmers MakeChoice method
            //if the method returns true, take a cup away from the cupsLeftInPitcher variable on the pitcher class and icrease the players money by the cost of a cup (pricePerCup on the recipe class)
            //if the method return false, then do nothing and let the loop move onto the next customer
        }
    }

    
}
