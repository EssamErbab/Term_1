/*  Program.cs
 * 
 *  Demo of creating and using methods, parameters, 
 * 
 *  Revision History
 *      Essam Erbab, Oct 4, 2023: Created
 *      Essam Erbab, Feb 29, 2023: Cleaned Code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            bool exit = false;
            string continueOption;
            string method;

            
            // 

            while (!exit)
            {
                Console.WriteLine("Welcome to Method Examples");
                Console.WriteLine("Pick Method\n\n" +
                                  "1: Print Name\n" +
                                  "2: Rectangle Area\n" +
                                  "3: Find Max, Method 1\n" +
                                  "4: Find Max, Method 2\n" +
                                  "5: Find Max, Method 3\n" +
                                  "6: Add Numbers\n" +
                                  "7: Inches to Cm\n" +
                                  "8: Welcome User\n" +
                                  "9: Area of Circle\n" +
                                  "" +
                                  "E: Exit");
                Console.Write("\nEnter: ");
                method = Console.ReadLine();
                Console.Clear();
                switch (method)
                {
                    case "1":
                        PrintName();
                        break;
                    case "2":
                        RectArea();
                        break; 
                    case "3":
                        FindMax1();
                        break;
                    case "4":
                        FindMax2();
                        break;
                    case "5":
                        FindMax3();
                        break;
                    case "6":
                        int num1, num2;
                        Console.Write("Enter a Number: ");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.Write("Enter a Number: ");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        AddNumbers(num1, num2);
                        break;
                    case "7":
                        double inches;

                        Console.Write("Enter a length in Inches: ");
                        inches = Convert.ToDouble(Console.ReadLine());

                        InchesToCm(inches);
                        break;
                    case "8":
                        string name;
                        string pin;

                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter PIN: ");
                        pin = Console.ReadLine();

                        WelcomeUser(name, pin);
                        break;
                    case "9":
                        Console.Write("Enter Radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Area of a circle with radius {radius} is {AreaCircle(radius)}");
                        break;
                    case "E":
                    case "e":
                        exit = true;
                        break;
                }
                if (!exit)
                {
                    Console.Write("Would you like to continue (Y/N): ");
                    continueOption = Console.ReadLine();
                    if (continueOption == "N" || continueOption == "n")
                    {
                        exit = false;
                    }
                    Console.Clear();
                }
            }

        }

        // 1. Print a name to the screen
        static void PrintName()
        {
            Console.WriteLine("Essam Erbab");
        }
        static void RectArea()
        {
            double width, height, area;

            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            area = width * height;
            Console.WriteLine($"\nThe area is {area}");
        }
        static void FindMax1()
        {
            int num1, num2, num3;

            Console.Write("Enter 1st Number: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 3rd Number: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            if(num1 > num2) 
            {
                if(num1 > num3) 
                {
                    Console.WriteLine($"{num1} is the biggest");
                }
                else 
                {
                    Console.WriteLine($"{num3} is the biggest");
                }
            }
            else if (num2 > num3) 
            {
                Console.WriteLine($"{num2} is the biggest");
            }
            else
            {
                Console.WriteLine($"{num3} is the biggest");
            }

        }
        static void FindMax2()
        {
            // variables

            int num1, num2, num3;

            // collecting values

            Console.Write("Enter 1st Number: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 3rd Number: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            // sort

            int[] nums = new int[]{num1, num2, num3};
            Array.Sort(nums);
            Array.Reverse(nums);

            // output

            Console.WriteLine(nums[0]);
        }
        static void FindMax3()
        {
            // variables

            int num1, num2, num3, max;

            // collecting values

            Console.Write("Enter 1st Number: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter 3rd Number: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            max = num1;

            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine($"{max} is the max");
        }
        static void AddNumbers(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"{x} + {y} = {sum}");
        }
        static void InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            Console.WriteLine($"{inches} Inches is {cm}cms");
        }
        static void WelcomeUser(string name, string pin)
        {
            Console.Clear();
            if ( pin == "1234")
            {
                Console.WriteLine($"Welcome {name}");
            }
            else
            {
                Console.WriteLine("Error: Wrong login, Try again");
            }
        }
        static double AreaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius,2);
            return area;
        }
    }
}
