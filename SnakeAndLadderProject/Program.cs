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
            int PlayerRollDiceCount = 0;

            int WinPosition = 100;
            //repeat till win position i.e. till 100

            while (PlayerPosition != 100)
            {
                int PlayerDice = rollDice();
                PlayerRollDiceCount++;
                int option = checkOption();
                // Use Switch case for option
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Players not play");
                        break;
                    case 2:
                        Console.WriteLine("Player got the Ladder");
                        PlayerPosition += PlayerDice;
                        //ensure win position 100
                        if (PlayerPosition > WinPosition)
                        {
                            PlayerPosition -= PlayerDice;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player got the Snake");
                        //In case player position moves below 0, then player starts from position 0 
                        if ((PlayerPosition - PlayerDice) < 0)
                        {
                            PlayerPosition = 0;
                        }
                        else
                        {
                            PlayerPosition -= PlayerDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong");
                        break;
                }
                //Report the number of times the dice was played to win the game and also the position after every die role
                if (PlayerPosition == WinPosition) 
                {
                    if (PlayerPosition == WinPosition)
                    {

                        Console.WriteLine("----------Player won !----------");
                        Console.WriteLine("Number of times dice was played by player to win the game is {0}", PlayerRollDiceCount);
                        break;
                    }
                }
            }
        }            
    }
}
