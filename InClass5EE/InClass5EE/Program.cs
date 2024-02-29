/*  Program.cs
 * 
 *  A program that emulates a login system that uses string manipulation
 * 
 *  Revision History:
 *      Essam Erbab, Nov 23, 2023: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass5EE
{
    internal class Program
    {
        static string username;
        static string password;
        static bool passwordPunctuation = false;
        static bool passwordDigit = false;
        static Random random = new Random();

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Username: ");
                username = Console.ReadLine();
                if (username.Length < 6)
                {
                    Console.WriteLine("Error: Enter a username with at least 6 letters");
                }
            } while (username.Length < 6);
            do
            {
                Console.Clear();
                Console.Write("Password: ");
                password = Console.ReadLine();

                for (int i = 0; i < password.Length; i++)
                {
                    if (passwordDigit && passwordPunctuation)
                    {
                        break;
                    }
                    if (char.IsDigit(password, i))
                    {
                        passwordDigit = true;
                    }
                    if (char.IsPunctuation(password, i))
                    {
                        passwordPunctuation = true;
                    }
                }
                
                if (password.Length < 8)
                {
                    Console.WriteLine("Error: Password must be at least 8 letters long");
                }
                if (!passwordPunctuation)
                {
                    Console.WriteLine("Error: No Punctuation in Password");
                }
                if (!passwordDigit)
                {
                    Console.WriteLine("Error: No Digit in Password");
                }
            } while(password.Length < 8);

            Console.Clear();

            username.ToLower();
            password.ToLower();

            username = username + random.Next(1, 101);

            password += (random.Next(1, 101)).ToString();

            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);

        }
    }
}
