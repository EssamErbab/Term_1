/*  program.cs
 * 
 *  Calculate & print customer's electricity bill
 * 
 *  Revision History:
 *      Essam Erbab & Chung-Ping Tsai, Oct 6, 2023: Created
 *      Essam Erbab, Feb 29, 2024: Cleaned Code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace A2ErbabETsaiCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            string customerID;
            string customerName;

            double unitsOfElectricity;
            double unitFeeSubtotal = 0;
            double unitFeeTotal = 0;
            double unitPrice;
            int loyaltyDiscount;

            string subsidyOption;
            bool subsidy = false;
            double subsidyValue = .1285;
            double subsidyAmount = 0;

            int yearsAsCustomer;

            // <<<=-= Inputs =-=>>>

            Console.WriteLine("Utility Bill Calculator");
            Console.WriteLine("--------------------------------------\n");

            Console.Write("Enter your name: ");
            customerName = Console.ReadLine();

            Console.Write("Enter your customer ID: ");
            customerID = Console.ReadLine();

            Console.Write("Enter Electrical Units Consumed: ");
            unitsOfElectricity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you eligible for subsidy? (Y/N): ");
            subsidyOption = Console.ReadLine();

            switch (subsidyOption)
            {
                case "Y":
                case "y":
                    subsidy = true;
                    break;
                case "N":
                case "n":
                    subsidy = false;
                    break;
                default:
                    Console.WriteLine("Error: Inputted value is not a valid option");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }

            Console.Write("Years as a customer?: ");
            yearsAsCustomer = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("\n--------------------------------------");

            // Calculations


            if (unitsOfElectricity < 200)
            {
                unitPrice = .20;
            }
            else if (unitsOfElectricity < 500)
            {
                unitPrice = .30;
            }
            else if (unitsOfElectricity < 800)
            {
                unitPrice = .50;
            }
            else
            {
                unitPrice = .75;
            }
            
            if (subsidy)
            {
                subsidyAmount = unitsOfElectricity * unitPrice * subsidyValue;
            }

            switch (yearsAsCustomer)
            {
                case 0:
                case 1:
                    loyaltyDiscount = 0;
                    break;
                case 2:
                case 3:
                    loyaltyDiscount = 5;
                    break;
                case 4:
                case 5:
                case 6:
                    loyaltyDiscount = 10;
                    break;
                default:
                    loyaltyDiscount = 15;
                    break;
            }

            unitFeeSubtotal = unitsOfElectricity * unitPrice - loyaltyDiscount - subsidyAmount;
            unitFeeTotal += unitFeeSubtotal + (unitFeeSubtotal * .13);
            

            // Outputs
            Console.Clear();
            Console.WriteLine($"Electricity Bill\n" +
                              $"--------------------------------------\n\n" +
                              $"Customer Name:                  {customerName}\n" +
                              $"Customer ID:                    {customerID}\n\n" +
                              $"Units Consumed:                 {unitsOfElectricity}\n" +
                              $"Unit Fee @ {unitPrice}/unit:            {(unitsOfElectricity * unitPrice).ToString("C")}\n" +
                              $"Loyalty Discount:               {loyaltyDiscount.ToString("C")}\n" +
                              $"Subsidy Amount:                 {subsidyAmount.ToString("C")}\n\n" +
                              $"Subtotal:                       {unitFeeSubtotal.ToString("C")}\n" +
                              $"Tax Amount:                     {(unitFeeSubtotal * .13).ToString("C")} \n" +
                              $"Total Amount Owed:              {unitFeeTotal.ToString("C")}");
            
            /*
            Electricity Bill

            Customer Name:            Name
            Customer ID:              ID

            Units Consumed:           Units
            Unit Fee @.30/unit:       Units * Unit Price
            Loyalty Discount:         Loyalty Discount
            Subsidy Amount:           Subsidy Amount

            Subtotal:                 Subtotal
            Tax Amount:               Tax Amount
            Total Amount Owed:        Total

             */
            Console.ReadKey();
        }
    }
}

