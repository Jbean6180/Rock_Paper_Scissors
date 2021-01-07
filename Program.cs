using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Rock_PaperScissors
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between Rock, Paper and Scissors: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random ran = new Random();

                    randomInt = ran.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK!");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Win!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer Wins!");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("Computer chose PAPER!");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer Wins!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player Win!");
                                scorePlayer++;
                            }

                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("Computer chose SCISSORS!");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Win!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer Wins!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            break;
                        default:
                            Console.WriteLine("Please Try Again, Entry Invalid");
                            break;
                    }

                    Console.WriteLine($"Player Score: {scorePlayer}");
               
                    Console.WriteLine($"Computer Score: {scoreCPU}");

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player Wins");

                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("Computer has won!");
                    }
                }

                Console.WriteLine("Do you want to play again?");
                string loop = Console.ReadLine();
                if (loop == "yes")
                {
                    playAgain = true;
                }
                else if (loop == "no")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("I Hope You Enjoyed The Game!");
                }
            }
        }
    }
}
