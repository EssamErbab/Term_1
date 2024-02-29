/*  Program.cs
 * 
 *  
 *  
 *  Revision History
 *      Essam Erbab, Oct 5, 2023: Created
 *      Essam Erbab, Feb 29, 2024: Modified & Cleaned Code
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssamEInClass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles

            string menuOption;
            bool exit = false;
            double num1, num2, sum = 0;
            char operation = '1';

            // Output
            while (!exit)
            {
                Console.WriteLine("Welcome to In Class Assignment 3\n");

                Console.Write("Enter 1st number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nWhat would you like to do with these numbers?");

                Console.WriteLine("Enter an option\n" +
                                  "1: Add Numbers\n" +
                                  "2: Subtract Numbers\n"+
                                  "3: Divide Numbers\n"+
                                  "2: Multiply Numbers\n" +
                                  "E: Exit\n");
                Console.Write("Enter: ");
                menuOption = Console.ReadLine();
                Console.Clear();
                switch(menuOption)
                {
                    case "1":
                        sum = AddNumbers(num1, num2);
                        operation = '+';
                        break;
                    case "2":
                        sum = SubtractNumbers(num1, num2);
                        operation = '-';
                        break; 
                    case "3":
                        sum = DivideNumbers(num1, num2);
                        operation = '/';
                        break;
                    case "4":
                        sum = MultiplyNumbers(num1, num2);
                        operation = '*';
                        break;
                    case "E":
                    case "e":
                        exit = true;
                        break;
                    default: 
                        Console.WriteLine("Error: Inputted value isn't an option try again");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if(!exit)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {sum}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }
        static double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }
        static double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
        static double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
