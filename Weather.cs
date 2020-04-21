using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int tempurture;
        private List<string> weatherConditions;
        public Random rng;

        // constructor (SPAWNER)
        public Weather()
        {
            weatherConditions = new List<string>() { "Rainy", "Sunny", "Cloudy", "Overcast", "Stormy" };
            condition = GenerateCondition();
        }

        // member methods (CAN DO)
        public string GenerateCondition()
        {
            //set the condtion variable to a random condtion from our list of weatherCondtions
            int randomNumber = rng.Next(6);
            return weatherConditions[randomNumber];
        }

        public void GenerateTemperature()
        {
            //set temperature equal to a random number between 40 and 100
            tempurture = rng.Next(40, 101);
        }
    }
}
