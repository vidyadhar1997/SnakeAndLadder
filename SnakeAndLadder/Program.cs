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

        public static int playerOption()
        {
            int throwDices = throwDice();
            int selectdOption = checkForOption();
            if (selectdOption == 2)
            {
                currentPoistion += throwDices;
            }
            else if (selectdOption == 3)
            {
                currentPoistion -= throwDices;
                if (currentPoistion < 0)
                {
                    currentPoistion = START_POISTION;
                }
            }
            else
            {
                Console.WriteLine("Do nothing player stay in same poistion");
            }
            return currentPoistion;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("start postion is: "+START_POISTION);
            Console.WriteLine("end postion is: " + END_POSTION);
            Console.WriteLine("current poistion is= " + playerOption());
        }
    }
}
