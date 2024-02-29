/*  program.cs
 *  
 *  A demo on arrays
 *  
 *  Revision History: 
 *      Essam Erbab, Nov 11, 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static int numbersSize = 5;
        static int[] tempArray = new int[numbersSize];
        static int[] numbers;
        static void Main(string[] args)
        {
            string Option = "";
            int arrayIndex1 = 0;
            bool showArray = true;

            numbers = new int[numbersSize];
            PopulateArray(numbers);
            do
            {
                Console.WriteLine("Array Manipulater \n");
                if (showArray)
                {
                    ShowArray(numbers);
                    Console.WriteLine();
                }
                Console.Write("Enter Option:\n\n" +
                                  "1. Show / Hide Array \n" +
                                  "2. Change Value \n" +
                                  "3. Swap Values\n" +
                                  "4. Set Array Size \n" +
                                  "E. Exit \n\n" +
                                  "Enter: ");
                Option = Console.ReadLine();
                if (Option == "1")
                {
                    showArray = !showArray;
                }
                else if (Option == "2")
                {
                    ChangeArrayValue();
                }
                else if (Option == "3")
                {
                    SwapArrayValue();
                }
                else if (Option == "4")
                {
                    SetSize();
                }
                Console.Clear();
            } while (Option != "E");
        }
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }
        static void ChangeArrayValue()
        {
            int indexChosen;
            int inputtedValue;
            Console.Write($"Which Index? (0 - {numbersSize - 1}): ");
            indexChosen = Convert.ToInt16(Console.ReadLine());
            Console.Write($"Change to what value?: ");
            inputtedValue = Convert.ToInt16(Console.ReadLine());

            numbers[indexChosen] = inputtedValue;

            Console.WriteLine($"{indexChosen}: {numbers[indexChosen]}\n");

           

        }
        static void SwapArrayValue()
        {
            int indexChosen1;
            int indexChosen2;
            int temp;
            Console.WriteLine($"Which Index? (0 - {numbersSize-1}): ");
            indexChosen1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Which Index? (0 - {numbersSize-1}): ");
            indexChosen2 = Convert.ToInt16(Console.ReadLine());

            temp = numbers[indexChosen1];
            numbers[indexChosen1] = numbers[indexChosen2];
            numbers[indexChosen2] = temp;

            Console.WriteLine($"\n{indexChosen1}: {numbers[indexChosen1]}");
            Console.WriteLine($"{indexChosen2}: {numbers[indexChosen2]}");
        }
        static void PopulateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }
        static void SetSize()
        {
            Console.WriteLine("How big do you want your array? (0<): ");
            numbersSize = Convert.ToInt16(Console.ReadLine());

            Array.Resize(ref numbers, numbersSize);
        }
    }
}
