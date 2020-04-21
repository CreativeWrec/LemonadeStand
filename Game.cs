using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //Present the basic Lemonade Stand  [Player]                                                                                                    [Game]
        //Build weather system that predicts/includes forecast & actual weather for a day/week and actual weather on current day                        [Weather]
        //Have ability to purchase items from store                                                                                                     [Store]+
        //Product Price && Weather/Temp affects demand, if price++, then sales-- || if price--, then sales++                                            [Game]
        //Have each customers act as its own individual so that each purchase can track how much a customer is willing to pay, customer to customer     [Customer]+
        //Create a recipe (formula) that will call for x-amount of lemons, sugar, & ice                                                                 [Game]+
        //Game should last for seven days/rounds                                                                                                        [Game]+
        //Display daily profit or loss & total profit or loss at the end of each day                                                                    [Day]+
        //Implement SOLID principles so that C# best practices are shown                                                                                [Principal]
        //Pinpoint two places where I used two SOLID principles & discuss its reasoning.                                                                [Principal]
        
            ///Bonus Points///
        //Make game playable up to 4 players (HvH, HvC)
        //Have ability to save game data that can be accessed after the app is closed
        //Have ability to to register & login to play with individual save file
        //Inergrate a Weather API into your game so that the game has real-time weather based on a current temperature & forecast.

        //Variable (Has a)
        public Player player;
        public List<Day> days;
        public Store store;
        public Weather weather;
        public Random rng;

        //Construtor
        public Game()
        {
            player = new Player();
            weather = new Weather();
            store = new Store();
            days = new List<Day>();
            rng = new Random();
            GenerateDays();

        }
        public void RunGame()
        {

        }

        //Method (Can do)
        public void GenerateDays()
        {
            List<string> dayNames = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //generated random number
            
            int randomNumber = rng.Next(0, 7);
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day(dayNames[i]));
            }

            
        }

        public void GoToStore()
        {
            Console.WriteLine();
            string response = Console.ReadLine();
            if (response == "yes")
            {
                store.SellLemons(player);
                store.SellCups(player);
                store.SellIceCubes(player);
                store.SellSugarCubes(player);
            }
            else
            {

            }
        }
    }
}
