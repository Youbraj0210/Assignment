using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class PigDice
    {

        public static int target = 20;
        public static int turns = 1;
        public static int maxturns = 3;
        public static int turnBreaker = 1;
        public static int currValue;
        public static int holdValue;

        private static void TakeTurn()
        {
            int diceValue = RollDice();
            Console.WriteLine("turn {0}",turns);
            Console.WriteLine("Dice rolled Value: {0}",diceValue);
            currValue += diceValue;

            if(diceValue == turnBreaker)
            {
                Console.WriteLine("Turn Over, You Hold: {0}",holdValue);
                currValue = 0;
                turns++;
            }

        }

        private static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(1,10);
        }
        public static void StartGame()
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("To Roll enter 'r' and to Hold enter 'h'");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "r":
                        {
                            TakeTurn();
                        }
                        break;
                    case "h":
                        {
                            turns++;
                            holdValue += currValue;
                            currValue = 0;
                            Console.WriteLine("The value you hold is: "+ holdValue);
                        }
                        break;
                }

                if(holdValue >= target)
                {
                    start = false;
                    Console.WriteLine("You WON!");
                }

                if(holdValue < target && turns > maxturns)
                {
                    start = false;
                    Console.WriteLine("You Loose!");
                }
                //start = false;
            }
        }
    }
}
