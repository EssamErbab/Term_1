/*  Program.cs
 * 
 *  A personal program meant to emulate a classic ascii style game with movement and tiles 
 * 
 *  Revision History
 *      Essam Erbab, Nov 15, 2023: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace TestGame
{
    internal class Program
    {
        static string[,] grid = new string[10, 10];
        static ConsoleKeyInfo key;
        static int[] player = new int[6]; 
        static void Main(string[] args)
        {
            FillLevel(grid);
            do
            {
                DisplayLevel(grid);
                FindPlayer(grid);
                Thread.Sleep(100);
                key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.W ||
                   key.Key == ConsoleKey.S || 
                   key.Key == ConsoleKey.A ||
                   key.Key == ConsoleKey.D)
                {
                    MovePlayer(key.Key, grid, player);
                }
                Console.Clear();
            } while (true);
        }

        // Fills level with objects (init)
        static void FillLevel(string[,] level)
        {
            level[5, 5] = "P ";
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    if (level[i, j] == "" || level[i, j] == null)
                    {
                        level[i, j] = "  ";
                    }
                }
            }
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    if (j >= 0 && j <= 3)
                    {
                        if (i >= 0 && i <= 3)
                        {
                            level[i, j] = "T ";
                        }
                    }
                }
            }
        }

        // Displays the level (Update)
        static void DisplayLevel(string[,] level)
        {
            for (int i = 0; i < level.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    if (level[i, j] == "T ")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (level[i, j] == "P ")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(level[i, j] + " ");
                }
            }
        }
        
        // Finds Player (init)
        static void FindPlayer(string[,] level)
        {
            for (int i = 0;i < level.GetLength(0);i++)
            {
                for (int j = 0;j < level.GetLength(1);j++)
                {
                    if (level[i, j] == "P ")
                    {
                        player[0] = i;
                        player[1] = j;
                        break;
                    }
                }
            }
        }
        static void MovePlayer(ConsoleKey key, string[,] level, int[] player)
        {
            level[player[0], player[1]] = "  ";
            if (key == ConsoleKey.W)
            {
                if (player[0] > 0)
                {
                    player[0]--;
                }
            }
            else if (key == ConsoleKey.S)
            {
                if (player[0] < level.GetLength(0) - 1)
                {
                    player[0]++;
                }
            }
            else if (key == ConsoleKey.A)
            {
                if (player[1] > 0)
                {
                    player[1]--;
                }
            }
            else if(key == ConsoleKey.D)
            {
                if (player[1] < level.GetLength(0) - 1)
                {
                    player[1]++;
                }
            }
            level[player[0], player[1]] = "P ";
        }

    }
}
