using System;

namespace Hello
{
    public class StartUp
    {
        static void Main()
        {
            string inputPlayer, inputCPU;

            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scoreCPU < 3 && scorePlayer < 3)
                {
                    Console.Write("Choose between Rock, Paper or Scissors:\t");

                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer chose Rock");

                            if (inputPlayer == "rock" || inputPlayer == "r")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (inputPlayer == "paper" || inputPlayer == "p")
                            {
                                Console.WriteLine("Player wins round\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors" || inputPlayer == "s")
                            {
                                Console.WriteLine("Computer wins round\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose paper");

                            if (inputPlayer == "rock" || inputPlayer == "r")
                            {
                                Console.WriteLine("Computer wins round\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "paper" || inputPlayer == "p")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (inputPlayer == "scissors" || inputPlayer == "s")
                            {
                                Console.WriteLine("Player wins round\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer chose scissors");

                            if (inputPlayer == "rock" || inputPlayer == "r")
                            {
                                Console.WriteLine("Player wins round\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors" || inputPlayer == "s")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (inputPlayer == "paper" || inputPlayer == "p")
                            {
                                Console.WriteLine("Computer wins round\n");
                                scoreCPU++;
                            }
                            break;


                        default:
                            Console.WriteLine("Invalid entry.");
                            break;
                    }

                    Console.WriteLine("\n\nScore:  Player:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
                }

                if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer won!");
                }
                else if (scorePlayer == 3)
                {
                    Console.WriteLine("Player won!");
                }
                Console.WriteLine("Do you want to play again?    y/n");

                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
