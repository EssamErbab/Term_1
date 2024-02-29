/*  Program.cs
 * 
 *  a program to sort an student marks and display the average
 * 
 *  Revision History
 *      Essam Erbab, Nov 9, 2023: Created
 *      Essam Erbab, Feb 29, 2024: Cleaned Code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InClass4EE
{
    internal class Program
    {
        static int classLength;
        static int[] studentMarks = new int[1];
        static int average = 0;
        static bool exit = false;
        static string option;
        static void Main(string[] args)
        {
            GatherMarks();
            Console.Clear();
            do
            {
                try
                {
                    ShowMarks();
                    Console.Write("\nPick an Option: \n\n" +
                                      "1. Sort Highest\n" +
                                      "2. Sort Lowest\n" +
                                      "3. Average Score\n" +
                                      "E. Exit\n\n" +
                                      "Enter: ");
                    option = Console.ReadLine();
                    
                    switch(option)
                    {
                        case "1":
                            SortHighest();
                            break;
                        case "2":
                            SortLowest();
                            break;
                        case "3":
                            AverageScore();
                            Console.ReadKey();
                            break;
                        case "E":
                        case "e":
                            exit = true;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    Console.Clear();
                }
                catch (ArgumentOutOfRangeException )
                {
                    Console.WriteLine("\nError: Pick an option from the list");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!exit);
        }
        static void GatherMarks()
        {
            Console.Write("How many students in class: ");
            classLength = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Array.Resize(ref studentMarks, classLength);
            for (int i = 0; i < studentMarks.Length; i++)
            {
                try
                {
                    Console.Write($"Enter Student {i + 1}'s mark: ");
                    studentMarks[i] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();
                    if (studentMarks[i] > 100 || studentMarks[i] < 0)
                    {
                        throw new Exception();
                    }
                } 
                catch 
                {
                    Console.WriteLine("Error: Enter an a value between 0 - 100");
                    Console.WriteLine();
                    i--;
                }
            }
        }   
        static void ShowMarks()
        {
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine((i+1) + ": " + studentMarks[i]);
            }
        }
        static void SortLowest()
        {
            Array.Sort(studentMarks);
        }
        static void SortHighest()
        {
            Array.Sort(studentMarks);
            Array.Reverse(studentMarks);
        }
        static void AverageScore()
        {

            for (int i = 0; i < studentMarks.Length; i++)
            {
                average += studentMarks[i];
            }

            average = average / studentMarks.Length;

            Console.WriteLine($"The average score is {average}");
        }
    }
}
