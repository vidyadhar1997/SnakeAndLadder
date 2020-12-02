using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int WIN_POSTION = 100;
        public static int currentPoistion = 0;
        static Random random = new Random();
        public static int throwDice()
        {
            return random.Next(1, 7);
        }

        public static int checkForOption()
        {
            return random.Next(1, 4);
        }

        static void Main(string[] args)
        {
            int RollDiceCount = 0;
            while (currentPoistion < WIN_POSTION - 1)
            {
                int throwDices = throwDice();
                RollDiceCount++;
                int selectdOption = checkForOption();
                switch (selectdOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPoistion += throwDices;
                        Console.WriteLine("current poistion is ="+currentPoistion);
                        if (currentPoistion > WIN_POSTION)
                        {
                            currentPoistion -= throwDices;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((currentPoistion - throwDices) < 0)
                        {
                            currentPoistion = 0;
                        }
                        else
                        {
                            currentPoistion -= throwDices;
                            Console.WriteLine("current poistion is ="+currentPoistion);
                        }
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }
                if (currentPoistion == WIN_POSTION)
                {
                    Console.WriteLine("Player won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + RollDiceCount);
                    break;
                }

            }
        }

    }
}
