/*  Program.cs
 *  
 *  A program that is a simple slot machine to demonstrate the use of ifs and switches
 *  
 *  Revision History:
 *      Essam Erbab, Sept 28, 2023: Created
 *      Essam Erbab, Feb 29, 2024: Cleaned Code
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArmedBandit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int slot1 = 0;
            int slot2 = 0;
            int slot3 = 0;
            int turn = 0;

            Random randGen = new Random();
            
            // Outputs

            Console.WriteLine("The One Armed Bandit");
            Console.WriteLine("Welcome to the One Armed Bandit \n");
            Console.WriteLine("Press ENTER to play");
            Console.ReadKey();

            while (turn < 20) // 20 * 250 /1000 = 5 seconds
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

                Thread.Sleep(250);

                turn++;
            }
            while (turn < 30) // 10 * 250 / 1000 = 2.5 seconds
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The One Armed Bandit");
                Console.ForegroundColor = ConsoleColor.White;

                // randomly generate numbers

                slot2 = randGen.Next(1, 6);
                slot3 = randGen.Next(1, 6);

                // Check cases
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                SlotRoll(slot1);
                Console.ForegroundColor = ConsoleColor.White;
                SlotRoll(slot2);
                SlotRoll(slot3);

                Thread.Sleep(250);

                turn++;
            }
            while (turn < 40) // 10 * 250 / 1000 = 2.5 seconds
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

                Thread.Sleep(250);

                turn++;
            }
            while (turn == 40) // 10 * 250 / 1000 = 2.5 seconds
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

                Thread.Sleep(250);

                turn++;
            }

            // Outcome

            if (slot1 == slot2 && slot2 == slot3)
            {
                Console.WriteLine("\nWinner");
            }
            else if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
            {
                Console.WriteLine("\n2 out of 3");
            }
            else
            {
                Console.WriteLine("\nLose");
            }

            Console.ReadKey();
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
    }
}
