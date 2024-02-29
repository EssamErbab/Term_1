/*  Program.cs
 * 
 *  A program that revists the One Armed Bandit game and adds a betting system & replayability
 * 
 *  Revision History
 *      Essam Erbab, Nov 2, 2023: Created
 *      Essam Erbab, Feb 29, 2024: Cleaned Code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OneArmedBanditV2
{
    internal class Program
    {
        static int slot1, slot2, slot3;
        static int betAmount = 1;
        static int timer;
        static Random randGen = new Random();
        static int coins = 10;
        static void Main(string[] args)
        {
            betAmount = 0;

            Console.WriteLine("The One Armed Bandit");
            Console.WriteLine("Welcome to the One Armed Bandit \n");

            do
            {
                Console.Write($"Enter Bet Amount (1 - {coins})\n" +
                                $"Enter 0 to exit\n\n" +
                                $"Enter: ");
                betAmount = Convert.ToInt32(Console.ReadLine());

                if (betAmount <= coins)
                {
                    coins -= betAmount;

                    if (betAmount > 0)
                    {
                        GameLoop();
                        DisplayResults();

                        Console.WriteLine("\nPress Enter to Continue ... ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nEntered Amount is over your coin amount\n\n" +
                                      "Press Enter to Continue ... ");
                    Console.ReadKey();
                    Console.Clear();
                }
                timer = 0;
            } while (betAmount != 0 && coins > 0);
            Environment.Exit(1);
        }
        static void GameLoop()
        {
            while (timer < 20) // 20 * 250 /1000 = 5 seconds
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The One Armed Bandit");
                Console.ForegroundColor = ConsoleColor.White;

                // randomly generate numbers

                slot1 = randGen.Next(1, 6);
                slot2 = randGen.Next(1, 6);
                slot3 = randGen.Next(1, 6);

                // Check cases

                SlotRoll(slot1);
                SlotRoll(slot2);
                SlotRoll(slot3);

                Console.WriteLine($"\nYou have ${coins}");

                Thread.Sleep(250);

                timer++;
            }
            while (timer < 30) // 10 * 250 / 1000 = 2.5 seconds
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The One Armed Bandit");
                Console.ForegroundColor = ConsoleColor.White;

                // randomly generate numbers

                slot2 = randGen.Next(1, 6);
                slot3 = randGen.Next(1, 6);

                // Check cases

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SlotRoll(slot1);
                Console.ForegroundColor = ConsoleColor.White;
                SlotRoll(slot2);
                SlotRoll(slot3);

                Console.WriteLine($"\nYou have ${coins}");

                Thread.Sleep(250);

                timer++;
            }
            while (timer < 40) // 9 * 250 / 1000 = 2.25 seconds
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The One Armed Bandit");
                Console.ForegroundColor = ConsoleColor.White;

                // randomly generate numbers

                slot3 = randGen.Next(1, 6);

                // Check cases

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SlotRoll(slot1);
                SlotRoll(slot2);
                Console.ForegroundColor = ConsoleColor.White;
                SlotRoll(slot3);

                Console.WriteLine($"\nYou have ${coins}");

                Thread.Sleep(250);

                timer++;
            }
            while (timer == 40) // 1 * 250 / 1000 = 0.25 seconds
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The One Armed Bandit");
                Console.ForegroundColor = ConsoleColor.White;

                // randomly generate numbers

                // Check cases

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SlotRoll(slot1);
                SlotRoll(slot2);
                SlotRoll(slot3);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"\nYou have ${coins}");

                Thread.Sleep(250);

                timer++;
            }
        }
        static void SlotRoll(int slot)
        {
            switch (slot)
            {
                case 1:
                    Console.Write("@ ");
                    break;
                case 2:
                    Console.Write("# ");
                    break;
                case 3:
                    Console.Write("$ ");
                    break;
                case 4:
                    Console.Write("O ");
                    break;
                case 5:
                    Console.Write("X ");
                    break;
            }
        }
        static void DisplayResults()
        {
            if (slot1 == slot2 && slot2 == slot3)
            {
                Console.WriteLine("\nWinner");
                coins += betAmount;
            }
            else if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
            {
                Console.WriteLine("\n2 out of 3");
            }
            else
            {
                Console.WriteLine("\nLoser");
            }
        }
    }
}