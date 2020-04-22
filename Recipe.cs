using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //Variable (Has A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        
        //Constructor
        public Recipe()
        {

        }

        //Method (Can do)
        public void SetRecipe()
        {
            Console.WriteLine("Please enter in how many lemons per pitcher you would like to use.");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in how many Sugar Cubes per pitcher you would like to use");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in how many Ice Cubes per pitcher you would like to use");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in how many Cups per pitcher you would like to use");
            pricePerCup = .25; Convert.ToDouble(Console.ReadLine());

        }
    }
}
