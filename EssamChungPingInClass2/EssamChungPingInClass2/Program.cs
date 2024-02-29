/* Program.cs
 * 
 * A demo to calculate the price of apples and banana the user bought
 * 
 * Revision History:
 *      Essam Erbab & Chung-ping tsai, 2023.09.21: Created
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssamChungPingInClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles

            int appleAmount;
            int bananaAmount;
            double applePrice = 1.50;
            double bananaPrice = 1.20;
            double subTotal;
            double total;
            double taxDeducted;
            double taxRate = 0.13;

            // Inputs 

            Console.Write("How many apples would you like? ");
            appleAmount = Convert.ToInt16(Console.ReadLine());
            Console.Write("How many bananas would you like? ");
            bananaAmount = Convert.ToInt16(Console.ReadLine());

            // Calculations

            subTotal = appleAmount * applePrice + bananaAmount * bananaPrice;
            taxDeducted = subTotal * taxRate;
            total = subTotal + taxDeducted;

            // Outputs

            Console.WriteLine($"Subtotal: {subTotal.ToString("c")}");
            Console.WriteLine($"Tax:      {taxDeducted.ToString("c")}");
            Console.WriteLine($"Total:    {total.ToString("c")}");
            Console.ReadKey();

        }
    }
}
