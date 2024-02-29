/*  Program.cs
 *  
 *  A demo on how to create variables and perform basic math operations
 *  
 *  Revision History:
 *      Essam Erbab, Sept 20, 2023: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Essam";
            int age = 18;
            double height = 1.72;
            int x = 7;
            int y = 5;
            int answer;
            double doubleAnswer;
            double doubleX = 11;
            double doubleY = 7;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " +height +" m");

            Console.WriteLine();
            Console.WriteLine("Hello " + name + ", you are " + age + " years old");
            Console.WriteLine($"Hello {name}, you are {age} years old");

            answer = x + y;
            Console.WriteLine($"{x} + {y} = {answer} (+)");

            answer = x - y;
            Console.WriteLine($"{x} - {y} = {answer} (-)");

            answer = x * y;
            Console.WriteLine($"{x} * {y} = {answer} (*)");

            doubleAnswer = doubleX / doubleY;
            Console.WriteLine($"{x} / {y} = {doubleAnswer} (/)");

            answer = (int)(doubleX / doubleY);
            Console.WriteLine($"{x} / {y} = {answer} (cast to int)");

            answer = Convert.ToInt16(doubleX / doubleY);
            Console.WriteLine($"{x} / {y} = {answer} (convert to int)");
            Console.WriteLine();
            // Wage Calculator

            double payRate = 20;
            double hours = 10;
                
            double wage;
            wage = payRate * hours;

            Console.WriteLine($"Rate of Pay:  {payRate}");
            Console.WriteLine($"Hours Worked: {hours}");
            Console.WriteLine();
            Console.WriteLine($"Wage Earned:  {wage}");

            // Count + & -

            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            //

            Console.ReadKey();

        }
    }
}
