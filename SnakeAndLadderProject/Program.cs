using System;

namespace SnakeAndLadderProject
{
    class Program
    {
        // Function to roll a dice and get number between 1-6
        public static int rollDice()
        {
            Random random = new Random();
            int dicevalue = random.Next(0,7);
            return dicevalue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Project !");
            int PlayerPosition = 0;
            int PlayerDice = rollDice();
        }
    }
}
