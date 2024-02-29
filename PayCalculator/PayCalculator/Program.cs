/*  Program.cs
 *  
 *  A demo on getting inputs, converting values, preforming calculations, and formatting output
 *  
 *  Revision History:
 *      Essam Erbab, Sept 20, 2023: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            string firstName;
            string lastName;

            double hours;
            double payRate;
            double grossIncome;
            double incomeTax = 0.20;
            double taxDeducted;
            double netIncome;


            // Getting values from user

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter Hours Worked: ");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Pay Rate: ");
            payRate = Convert.ToDouble(Console.ReadLine());

            // Calculations

            grossIncome = hours * payRate;
            taxDeducted = grossIncome * incomeTax;
            netIncome = grossIncome - taxDeducted;

            // Outputs

            Console.Clear();
            Console.WriteLine($"Name:           {firstName} {lastName}\n" +
                              $"Hours:          {hours}h\n" +
                              $"Pay Rate:       {payRate.ToString("C")}/h\n" +
                              $"Gross Income:   {grossIncome.ToString("C")}\n\n" +
                              $"Income Tax:     {incomeTax} or {incomeTax * 100}%\n" +
                              $"Deducted:       {taxDeducted.ToString("C")}\n" +
                              $"Net Income:     {netIncome.ToString("C")}");
            Console.ReadKey();
             
        }
    }
}
