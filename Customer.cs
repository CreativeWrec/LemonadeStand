using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        private List<string> names;
        public string name;
        Random random;
        public Customer(Random rng)
        {
            random = rng;
        }

        public bool MakeBuyChoice(Weather weather, Recipe recipe)
        {
            int chanceNum = 0;
            if (weather.tempurture >= 80 && recipe.pricePerCup <= 1.00)
            {
                chanceNum = random.Next(4, 10);
            }
            else if (weather.tempurture <= 80 && recipe.pricePerCup >= 1.00)
            {
                chanceNum = random.Next(0, 10);
            }


            if(chanceNum >= 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        //MakeBuyChoice(Weather weather, Recipe recipe)

        //try to think of way to use the varaiables on the weather and recipe to generate a chance that the customer will buy or not



        
    }   

}
