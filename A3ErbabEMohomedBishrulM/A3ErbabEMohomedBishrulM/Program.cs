/*  Program.cs
 * 
 *  A game of Rock Paper Scissor against a bot
 *  
 *  Revision History
 *      Essam Erbab & Mohomed Bishrul, Nov 10, 2023: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace A3ErbabEMohomedBishrulM
{
    internal class Program
    {
        static int playerChoice, botChoice;
        static bool playerWins = false, playerTie = false;
        static bool exit;
        static int numOfRounds;
        static int playerScore, botScore;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Rock Paper Scissors game");
            while (numOfRounds == 0)
            {
                NumberOfRounds();
            }
            do
            {
                try
                {
                    DisplayMenu();

                    ShowSelection(playerChoice, botChoice);
                    WinCondition(playerChoice, botChoice);

                    Console.ReadKey();
                    Console.Clear();

                    playerChoice = 0;
                    botChoice = 0;
                    playerTie = false;

                    numOfRounds--;
                    if (numOfRounds == 0)
                    {
                        if (playerScore == botScore)
                        {
                            numOfRounds++;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Pick from the options");
                }

            } while (!exit && numOfRounds != 0);

            // Winner

            Console.Clear();
            Console.Write("Overall Winner: ");
            if (playerScore > botScore)
            {
                Console.WriteLine("Player");
            }
            else if (playerScore < botScore)
            {
                Console.WriteLine("Bot");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void NumberOfRounds()
        {
            try
            {
                Console.Write("Enter Number of Rounds (1 - 10): ");
                numOfRounds = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (numOfRounds < 0 || numOfRounds > 10)
                {
                    numOfRounds = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Enter a Number between 1 - 10");
            }
        }
        static void DisplayMenu()
        {
            Console.Write($"Player Score: {playerScore}\n" +
                                  $"Bot Score: {botScore}\n\n" +
                                  $"Number of Rounds Remaining: {numOfRounds}\n\n" +
                                  $"Pick an Option\n\n" +
                                  $"1. Rock\n" +
                                  $"2. Paper\n" +
                                  $"3. Scissors\n\n" +
                                  $"Enter: ");
            playerChoice = Convert.ToInt16(Console.ReadLine());

            if (playerChoice < 1 || playerChoice > 3)
            {
                throw new Exception();
            }
            botChoice = random.Next(1, 4);
            Console.Clear();
        }
        static void ShowSelection(int player, int bot)
        {
            Console.WriteLine("Rock");
            Thread.Sleep(500);
            Console.WriteLine("Paper");
            Thread.Sleep(500);
            Console.WriteLine("Scissors");
            Thread.Sleep(500);
            Console.WriteLine("Shoot\n");
            Thread.Sleep(500);

            // Player Choice
            {
                if (player == 1)
                {
                    Console.WriteLine("Player: Rock");
                }
                else if (player == 2)
                {
                    Console.WriteLine("Player: Paper");
                }
                else
                {
                    Console.WriteLine("Player: Scissors");
                }
            }

            // Bot Choice
            {
                if (bot == 1)
                {
                    Console.WriteLine("Bot: Rock");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Bot: Paper");
                }
                else
                {
                    Console.WriteLine("Bot: Scissors");
                }
            }
        }
        static void WinCondition(int player, int bot)
        {
            // Player Win Condition
            {
                if (player != bot)
                {
                    if (player == 1)
                    {
                        if (bot == 3)
                        {
                            playerWins = true;
                        }
                        else
                        {
                            playerWins = false;
                        }
                    }
                    else if (player == 2)
                    {
                        if (bot == 1)
                        {
                            playerWins = true;
                        }
                        else
                        {
                            playerWins = false;
                        }
                    }
                    else
                    {
                        if (bot == 2)
                        {
                            playerWins = true;
                        }
                        else
                        {
                            playerWins = false;
                        }
                    }
                }
                else
                {
                    playerTie = true;
                }
            }
            Console.Write("\nResult: ");
            if (!playerTie)
            {
                if (playerWins)
                {
                    Console.WriteLine("Player Wins");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Bot Wins");
                    botScore++;
                }
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}