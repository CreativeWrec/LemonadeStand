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
            amountOfLemons = 5;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 3;
            pricePerCup = .25;

        }
    }
}
