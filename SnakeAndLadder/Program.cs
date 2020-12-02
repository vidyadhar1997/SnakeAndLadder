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
            int playerOnePoistion = 0;
            int playerTwoPoistion = 0;
            int playerOneRollDiceCount = 0;
            int playerTwoRollDiceCount = 0;

            while (playerOnePoistion < WIN_POSTION - 1 || playerTwoPoistion<WIN_POSTION-1)
            {
                int playerOnethrowDices = throwDice();
                playerOneRollDiceCount++;
                int playerTwothrowDices = throwDice();
                playerTwoRollDiceCount++;
                int selectdOption = checkForOption();
                switch (selectdOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        playerOnePoistion +=playerOnethrowDices;
                        playerTwoPoistion += playerTwothrowDices;
                        if (playerOnePoistion > WIN_POSTION)
                        {
                            playerOnePoistion -= playerOnethrowDices;
                        }
                       else if (playerTwoPoistion > WIN_POSTION)
                        {
                            playerTwoPoistion -= playerTwothrowDices;
                        }
                        Console.WriteLine("player one poistion is =" + playerOnePoistion);
                        Console.WriteLine("player two poistion is =" + playerTwoPoistion);

                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((playerOnePoistion - playerOnethrowDices) < 0)
                        {
                            playerOnePoistion = 0;
                        }
                        else
                        {
                            playerOnePoistion -= playerOnethrowDices;
                        }
                        if ((playerTwoPoistion - playerTwothrowDices) < 0)
                        {
                            playerTwoPoistion = 0;
                        }
                        else
                        {
                            playerTwoPoistion -= playerTwothrowDices;
                        }
                        Console.WriteLine("player one poistion is =" + playerOnePoistion);
                        Console.WriteLine("player two poistion is =" + playerTwoPoistion);
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }
                if (playerOnePoistion == WIN_POSTION)
                {
                    Console.WriteLine("Player one is won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + playerOneRollDiceCount);
                    break;
                }
                else if ((playerTwoPoistion==WIN_POSTION) && (playerOnePoistion != WIN_POSTION))
                {
                    Console.WriteLine("Player two is won!");
                    Console.WriteLine("number of dice was played by player for win the game is =" + playerTwoRollDiceCount);
                    break;
                }
            }
        }
    }
}
