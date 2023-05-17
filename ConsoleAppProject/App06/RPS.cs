using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App06
{
    /// <summary>
    /// 
    /// This app will ask the user to enter ther number of miles (fromUnit) and convert it to feet or
    /// meters (toUnit) and it will also ask the user for the number of feet and convert it into miles.

    /// </summary>
    /// 
    /// <author>
    /// Martin Konecny Ver. 2.0
    /// </author>
    internal class RPS
    {
        public void Main()
        {

            // A loop which will keep the game running until the player decides to quit.
            do
            {
                // object to generate random number
                Random random = new Random();
                int yourScore = 0;
                int npcScore = 0;

                // Outputs the game title using console helpers 
                ConsoleHelper.OutputHeading("R-P-S Console Game!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                // Propmpts the user to enter their name
                Console.Write("Please enter your name: ");
                string playerName = Console.ReadLine();

                // loop for 3 rounds
                while (yourScore != 3 && npcScore != 3)
                {
                    Console.WriteLine(); // Prints a blank line
                    Console.WriteLine("Your Score: " + yourScore + ". NPC Score: " + npcScore); // Prints score

                    // Prompts the user to enter a letter for selection of rock, papper and scissors
                    Console.WriteLine("Please enter | 'R' for Rock | 'P' for Paper | or anything other for Scissors|");
                    string playerChoice = Console.ReadLine().ToLower();


                    // generates random number to make a selection for the computer
                    int enemyChoice = random.Next(0, 3);

                    // switch statement to determine the winner of the round
                    if (enemyChoice == 0) // NPC chose rock
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

                // displays the final score
                if (yourScore == 3)
                {
                    Console.WriteLine(playerName + ", You win!");
                }
                else
                {
                    Console.WriteLine(playerName + ", You lose!");
                }

                // prompts the user to play again or exit the game
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