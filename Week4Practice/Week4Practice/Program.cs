/*  Program.cs
 *  A demo of if statements, else statements, and switch blocks
 *  
 *  Revision History:
 *      Essam Erbab, Sept 27, 2023: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varibles

            bool exit = false;
            int problemNum = 0;
            string repeatProblem;
            

            int age;
            int Num1, Num2;
            double hours, overtime;
            string suit;

            string vowel, letterInputted;
            string[] vowels;
            bool isVowel = false;

            bool socksOn, hatsOn;
            string hurracineCatagory;
            string day;
            
            // Intro

            while (exit == false)
            {
                while (problemNum == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to week 4 practice\n");
                    Console.WriteLine("Enter a problem:\n");
                    Console.WriteLine("1: Voting Age \n" +
                                      "2: Compare Numbers \n" +
                                      "3: Overtime \n" +
                                      "4: Suits \n" +
                                      "5: Positive Or Negative \n" +
                                      "6: Vowel Checker \n" +
                                      "7: Clothing Worn \n" +
                                      "8: Hurricane Wind Speed \n" +
                                      "9: Day of the Week \n");
                    Console.Write("Enter: ");
                    problemNum = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }


                // 1. Voting Age
                while (problemNum == 1)
                {
                    Console.Write("Enter your age: ");
                    age = Convert.ToInt16(Console.ReadLine());

                    if (age >= 18)
                    {
                        Console.WriteLine("You may vote");
                    }
                    else
                    {
                        Console.WriteLine("You may not vote");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 2 compare Numbers
                while (problemNum == 2)
                {
                    Console.Write("Enter a number:");
                    Num1 = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Enter another number:");
                    Num2 = Convert.ToInt16(Console.ReadLine());

                    if (Num1 > Num2)
                    {
                        Console.WriteLine($"{Num1} is greater than {Num2}");
                    }
                    else if (Num1 < Num2)
                    {
                        Console.WriteLine($"{Num2} is greater than {Num1}");
                    }
                    else if (Num1 == Num2)
                    {
                        Console.WriteLine($"{Num1} is equal to {Num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 3. Overtime
                while (problemNum == 3)
                {
                    Console.Write("Enter Hours Worked: ");
                    hours = Convert.ToDouble(Console.ReadLine());

                    if (hours > 40)
                    {
                        overtime = hours - 40;
                        Console.WriteLine($"You worked {overtime} overtime hours");
                    }
                    else
                    {
                        Console.WriteLine($"You worked {hours} hours");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 4. Suits
                while (problemNum == 4)
                {
                    suit = "hearts";

                    if (suit == "hearts" || suit == "diamonds")
                    {
                        Console.WriteLine($"{suit} is a red card");
                    }
                    else
                    {
                        Console.WriteLine($"{suit} is a black card");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 5. Positive Or Negative
                while (problemNum == 5)
                {
                    Console.Write("Enter a number: ");
                    Num1 = Convert.ToInt16(Console.ReadLine());

                    if (Num1 > 0)
                    {
                        Console.WriteLine($"{Num1} is positive");
                    }
                    else if (Num1 < 0)
                    {
                        Console.WriteLine($"{Num1} is negative");
                    }
                    else
                    {
                        Console.WriteLine($"{Num1} is neither positive or negative");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 6. Vowel Checker

                while (problemNum == 6)
                {

                    Console.Write("Enter a Letter:");
                    letterInputted = Console.ReadLine();

                    vowel = "a e i o u A E I O U";
                    vowels = vowel.Split(' ');

                    for (int i = 0; i < vowels.Length; i++)
                    {
                        if (letterInputted == vowels[i])
                        {
                            Console.WriteLine($"{letterInputted} is a vowel");
                            isVowel = true;
                            break;
                        };

                    }
                    if (!isVowel)
                    {
                        Console.WriteLine($"{letterInputted} is not a vowel");
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 7. Clothing Worn

                while (problemNum == 7)
                {
                    socksOn = true;
                    hatsOn = true;

                    if (socksOn)
                    {
                        if (hatsOn)
                        {
                            Console.WriteLine("socks and hat on");
                        }
                        else
                        {
                            Console.WriteLine("sock on, hat off");
                        }
                    }
                    else
                    {
                        if (hatsOn)
                        {
                            Console.WriteLine("socks off, hat on");
                        }
                        else
                        {
                            Console.WriteLine("sock off, hat off");
                        }
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 8. Hurricane Wind Speed

                while (problemNum == 8)
                {
                    Console.Write("Enter a hurricane catagory (1 - 5): ");
                    hurracineCatagory = Console.ReadLine();

                    switch (hurracineCatagory)
                    {
                        case "1":
                            Console.WriteLine("Wind Speed: 119 - 153 km/hr");
                            break;
                        case "2":
                            Console.WriteLine("Wind Speed: 154 - 177 km/hr");
                            break;
                        case "3":
                            Console.WriteLine("Wind Speed: 178 - 209 km/hr");
                            break;
                        case "4":
                            Console.WriteLine("Wind Speed: 210 - 249 km/hr");
                            break;
                        case "5":
                            Console.WriteLine("Wind Speed: >249 km/hr");
                            break;
                        default:
                            Console.WriteLine("Error: Number entered is not a hurricane catagory \n" +
                                              "Enter number between 1 - 5");
                            break;
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }

                // 9. Day of the Week

                while (problemNum == 9)
                {
                    Console.Write("Enter a day of the week: ");
                    day = Console.ReadLine();

                    switch (day)
                    {
                        case "Monday":
                        case "monday":
                        case "Tuesday":
                        case "tuesday":
                        case "Wednesday":
                        case "wednesday":
                        case "Thursday":
                        case "thursday":
                        case "Friday":
                        case "friday":
                            Console.WriteLine("It's a Weekday");
                            break;
                        case "Saturday":
                        case "saturday":
                        case "Sunday":
                        case "sunday":
                            Console.WriteLine("It's a Weekend");
                            break;
                    }

                    // Repeat?

                    Console.Write("\n Want to repeat problem? (Y / N)\n" +
                                      "Enter: ");
                    repeatProblem = Console.ReadLine();
                    if (repeatProblem == "N")
                    {
                        problemNum = 0;
                        repeatProblem = null;
                    }
                }
                // End
                Console.ReadKey();
            }
        }
    }
}
