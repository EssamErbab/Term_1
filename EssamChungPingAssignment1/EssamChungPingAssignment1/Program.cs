/*program.cs
 * 
 * Assignment 1 for programming concepts I (PROG1925)
 * 
 * Revision History: 
 *      Essam & Chung-Ping, sept 27, 2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssamChungPingAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            string userName, userEmail;
            double inputTemp, outputTemp; // input = F, output = C
            string programExp;
            string countryOfBirth;

            // Inputs
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.Write("\nEnter your email: ");
            userEmail = Console.ReadLine();

            Console.Write("\nEnter a temperature (F): ");
            inputTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter your programming experience: ");
            programExp = Console.ReadLine();

            Console.Write("\nEnter your country of birth: ");
            countryOfBirth = Console.ReadLine();

            Console.Clear();

            // Calculations

            outputTemp = (inputTemp - 32) * 5 / 9;

            // Output

            Console.WriteLine($"{userName} - Assignment 1 Part 2");
            Console.WriteLine($"Email: {userEmail} \n");
            Console.WriteLine($"{inputTemp.ToString(".0")} degrees Fahrenheit is {outputTemp.ToString(".0")} degrees Celsius \n");
            Console.WriteLine($"Experience: {programExp}");
            Console.WriteLine($"Country born in: {countryOfBirth}");

            Console.ReadKey();
        }
    }
}



