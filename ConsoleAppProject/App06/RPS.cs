using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App06
{
    internal class RPS
    {
        public void Main()
        {
            do
            {

                Random random = new Random();
                int yourScore = 0;
                int npcScore = 0;

                ConsoleHelper.OutputHeading("R-P-S Console Game!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Write("Please enter your name: ");
                string playerName = Console.ReadLine();

                while (yourScore != 3 && npcScore != 3)
                {
                    Console.WriteLine(); // Prints a blank line
                    Console.WriteLine("Your Score: " + yourScore + ". NPC Score: " + npcScore);
                    Console.WriteLine("Please enter | 'R' for Rock | 'P' for Paper | or anything other for Scissors|");
                    string playerChoice = Console.ReadLine().ToLower();

                    int enemyChoice = random.Next(0, 3);

                    if (enemyChoice == 0) // Enemy chose rock
                    {
                        Console.WriteLine("NPC chooses Rock! ");

                        switch (playerChoice)
                        {
                            case "r":
                                Console.WriteLine("Tie!");
                                break;
                            case "p":
                                Console.WriteLine("You win this round!");
                                yourScore++;
                                break;
                            default:
                                Console.WriteLine("NPC wins this round!");
                                npcScore++;
                                break;
                        }
                    }
                    else if (enemyChoice == 1) // Enemy chose paper
                    {
                        Console.WriteLine("NPC chooses paper.");

                        switch (playerChoice)
                        {
                            case "r":
                                Console.WriteLine("NPC wins this round!");
                                npcScore++;
                                break;
                            case "p":
                                Console.WriteLine("Tie!");
                                break;
                            default:
                                Console.WriteLine("You win this round!");
                                yourScore++;
                                break;
                        }

                    }
                    else // Enemy chose scissors
                    {
                        Console.WriteLine("NPC chooses scissors.");

                        switch (playerChoice)
                        {
                            case "r":
                                Console.WriteLine("You win this round!");
                                yourScore++;
                                break;
                            case "p":
                                Console.WriteLine("NPC wins this round!");
                                npcScore++;
                                break;
                            default:
                                Console.WriteLine("Tie!");
                                break;
                        }
                    }

                }

                if (yourScore == 3)
                {
                    Console.WriteLine(playerName + ", You win!");
                }
                else
                {
                    Console.WriteLine(playerName + ", You lose!");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y/N)");
                string playAgainChoice = Console.ReadLine().ToLower();

                if (playAgainChoice != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }

            } while (true);
        }
    }
}