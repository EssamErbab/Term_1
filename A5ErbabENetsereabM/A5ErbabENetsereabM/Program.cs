/*  program.cs
 * 
 *  An hiring system & tracking system for HR
 *  
 *  Revision history:
 *      - Essam Erbab & Maranata Netsereab, Nov 29, 2023: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5ErbabENetsereabM
{
    internal class Program
    {
        static string Option;
        static bool exit = false;

        static int employeeAmount = 0;
        static Employee[] employees;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("BIG Company: Employee Bank\n");
                Console.Write("Pick an Option\n\n" +
                              "1. Add Employee\n" +
                              "2. Edit Existing Employee\n" +
                              "3. Display Employee\n" +
                              "E. Exit\n\n" +
                              "Enter: ");
                Option = Console.ReadLine();
                Console.Clear();
                switch (Option)
                {
                    case "1":
                        employeeAmount++;
                        AddEmployee();
                        break;
                    case "2":
                        EditEmployee();
                        break;
                    case "3":
                        DisplayEmployee();
                        break;
                    case "e":
                    case "E":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nError: Invalid Option");
                        break;
                }
                PressEnter();
            } while (!exit);
        }
        static void AddEmployee()
        {
            // Variables

            string ID = null;
            string firstName = null;
            string lastName = null;
            int monthlySalary = -1;

            // Change Employee Bank
            Array.Resize(ref employees, employeeAmount);

            // Set Employee ID
            do
            {
                try
                {
                    Console.Write("Enter Employee ID: ");
                    ID = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ID))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Invalid ID\n");
                    PressEnter();
                }
            } while (string.IsNullOrWhiteSpace(ID));

            // Set Employee First Name
            do
            {
                try
                {
                    Console.Write("Enter Employee First Name: ");
                    firstName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(firstName))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Invalid First Name\n");
                    PressEnter();
                    Console.WriteLine($"Enter Employee ID: {ID}");
                }
            } while (string.IsNullOrWhiteSpace(firstName));

            // Set Employee Last Name
            do
            {
                try
                {
                    Console.Write("Enter Employee Last Name: ");
                    lastName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(lastName))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Invalid Last Name\n");
                    PressEnter();
                    Console.WriteLine($"Enter Employee ID: {ID}");
                    Console.WriteLine($"Enter Employee First Name: {firstName}");
                }
            } while (string.IsNullOrWhiteSpace(lastName));

            // Set Employee Monthly Salary
            do
            {
                try
                {
                    Console.Write("Enter Employee Monthly Salary: ");
                    monthlySalary = Convert.ToInt16(Console.ReadLine());
                    if (string.IsNullOrWhiteSpace(monthlySalary.ToString()))
                    {
                        throw new Exception();
                    }
                    else if (monthlySalary < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Invalid Salary\n");
                    PressEnter();
                    Console.WriteLine($"Enter Employee ID: {ID}");
                    Console.WriteLine($"Enter Employee First Name: {firstName}");
                    Console.WriteLine($"Enter Employee Last Name: {lastName}");
                }
            } while (string.IsNullOrWhiteSpace(monthlySalary.ToString()) || monthlySalary < 0);

            // Store in New Employee Object

            Employee newEmployee = new Employee(ID.ToLower(), firstName, lastName, monthlySalary);
            employees[employeeAmount - 1] = newEmployee;
        }
        static void EditEmployee()
        {
            int index;
            string editOption;
            string change = null;

            // No Employees
            if (employeeAmount <= 0)
            {
                Console.WriteLine("Error: No Employee Hired");
            }
            // Employee(s)
            else
            {
                index = FindEmployee();
                Console.WriteLine();
                if (index >= 0)
                {
                    Console.WriteLine($"\nID:\t\t\t{employees[index].employeeID}\n" +
                                              $"First Name:\t\t{employees[index].employeeFirstName}\n" +
                                              $"Last Name:\t\t{employees[index].employeeLastName}\n" +
                                              $"Monthly Salary:\t\t{employees[index].employeeMonthlySalary}");

                    Console.Write("\nWhich Attribute do you want to edit?\n\n" +
                                      "1. First Name\n" +
                                      "2. Last Name \n" +
                                      "3. Salary\n\n" +
                                      "Enter: ");
                    editOption = Console.ReadLine();
                    Console.Clear();
                    switch (editOption)
                    {
                        // Change First Name
                        case "1":
                            do
                            {
                                try
                                {
                                    Console.Write("Change First Name to: ");
                                    change = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(change))
                                    {
                                        throw new Exception();
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Error: Invalid First Name");
                                }
                            } while (string.IsNullOrWhiteSpace(change));
                            // check not blank

                            employees[index].ChangeFirstName(change);
                            break;

                        // Change Last Name
                        case "2":
                            do
                            {
                                try
                                {
                                    Console.Write("Change Last Name to: ");
                                    change = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(change))
                                    {
                                        throw new Exception();
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Error: Invalid Last Name");
                                }
                            } while (string.IsNullOrWhiteSpace(change));

                            // check not blank

                            employees[index].ChangeLastName(change);
                            break;

                        // Change Salary
                        case "3":
                            do
                            {
                                try
                                {
                                    Console.Write("Change First Name to: ");
                                    change = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(change))
                                    {
                                        throw new Exception();
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Error: Invalid Salary");
                                }

                            } while (string.IsNullOrWhiteSpace(change));

                            // check if number only

                            employees[index].ChangeSalary(Convert.ToInt16(change));
                            break;

                        // Blank / Invalid
                        default:
                            Console.WriteLine("Error: Invalid Option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Error: No Employee Found");
                }
            }
        }
        static void DisplayEmployee()
        {
            // Display Variables
            int index;

            // No Employees
            if (employeeAmount <= 0)
            {
                Console.WriteLine("Error: No Employee Hired");
            }
            // Employee(s)
            else //if (employeeAmount > 0)
            {
                index = FindEmployee();
                Console.WriteLine();
                if (index >= 0)
                {
                    Console.WriteLine($"ID:\t\t\t{employees[index].employeeID}\n" +
                                      $"First Name:\t\t{employees[index].employeeFirstName}\n" +
                                      $"Last Name:\t\t{employees[index].employeeLastName}\n" +
                                      $"Monthly Salary:\t\t{employees[index].employeeMonthlySalary}");
                }
                else
                {
                    Console.WriteLine($"Error: No Employee Found");
                }
            }
        }
        static int FindEmployee()
        {
            // Find Variables
            string search = null;
            int index = -1;
            bool employeeFound = false;

            // Get Search ID
            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Enter Employee ID: ");
                    search = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(search))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Invalid ID\n");
                    PressEnter();
                }
            } while (string.IsNullOrWhiteSpace(search));

            // Search for ID
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].employeeID == search.ToLower())
                {
                    index = i;
                    employeeFound = true; 
                    break;
                }
            }
            if (!employeeFound)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }
        static void PressEnter()
        {
            Console.WriteLine("Press ENTER to continue ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
