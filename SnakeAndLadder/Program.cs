using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POISTION = 0;
        const int END_POSTION = 100;
        public static int currentPoistion = 0;

        public static int throwDice()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }

        static void Main(string[] args)
        {
            currentPoistion += throwDice();
            Console.WriteLine("Current poistion is=" + currentPoistion);
            Console.WriteLine("start postion is: "+START_POISTION);
            Console.WriteLine("end postion is: " + END_POSTION);
        }
    }
}
