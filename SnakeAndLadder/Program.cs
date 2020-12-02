using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POISTION = 0;
        const int END_POSTION = 100;
        public static int currentPoistion = 0;
        public static int selectdOption = 0;
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
            while (currentPoistion < END_POSTION - 1)
            {
                int throwDices = throwDice();
                int selectdOption = checkForOption();
                switch (selectdOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPoistion += throwDices;
                        if (currentPoistion > END_POSTION)
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
                        }
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }


            }
        }

    }
}
