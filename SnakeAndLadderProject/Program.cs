using System;

namespace SnakeAndLadderProject
{
    class Program
    {
        // Function to roll a dice and get number between 1-6
        public static int rollDice()
        {
            Random random = new Random();
            int dicevalue = random.Next(1,7);
            return dicevalue;
        }

        //Function to check Player get a Ladder or snake or player play or not
        public static int checkOption()
        {
            Random random = new Random();

            return random.Next(1, 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Project !");
            int PlayerPosition = 0;
            int PlayerDice = rollDice();
            int option = checkOption();
            // Use Switch case for option
            switch (option)
            {
                case 1:
                    Console.WriteLine("Players not play");
                    break;
                case 2:
                    Console.WriteLine("Player got the Ladder");
                    break;
                case 3:
                    Console.WriteLine("Player got the Snake");
                    break;
                default:
                    Console.WriteLine("Something Went Wrong");
                    break;
            }
        }
    }
}
