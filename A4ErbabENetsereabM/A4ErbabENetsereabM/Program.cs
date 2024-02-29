/*  Program.cs
 *  
 *  A character creation for an adventure game
 *  
 *  Revision history
 *      - Essam Erbab & Netsereab Maranata, November 22 2023: Createds
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A4ErbabENetsereabM
{
    internal class Program
    {
        // Variables
        static bool exit = false;

        static string option;

        static string[,] party = new string[maxPartySize, 3];
        static int partySize = 1;
        static int maxPartySize = 6; // Max
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Dungeons & Dragons: Party\n");
                Console.Write("Pick an Option \n\n" +
                                  "1. Add Character \n" +
                                  "2. Edit Chatacter \n" +
                                  "3. Delete Character \n" +
                                  "4. Display All Characters \n" +
                                  "E. Exit \n\n" +
                                  "Enter: ");
                option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "1":
                        partySize++;
                        AddCharacter();
                        break;
                    case "2":
                        EditCharacter();
                        break;
                    case "3":
                        DeleteCharacter();
                        break;
                    case "4":
                        DisplayParty();
                        break;
                    case "E":
                    case "e":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Dungeons & Dragons: Party\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Pick from the options provided\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press ENTER to continue ...");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (!exit);
        }
        static void AddCharacter()
        {
            string tempName = null, tempClass = null, tempLevel = null;
            // Set Character Name
            do
            {
                Console.WriteLine("Dungeons & Dragons: Party\n");
                try
                {
                    Console.Write("Character Name: ");
                    tempName = Console.ReadLine();
                    for (int i = 0; i < partySize; i++)
                    {
                        if (party[i, 0].ToLower() == tempName.ToLower())
                        {
                            throw new Exception();
                        }
                    }
                    if (string.IsNullOrWhiteSpace(tempName))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        party[partySize - 1, 0] = tempName;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Enter Your Character's Name\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to Continue ...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Character's Name Used \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to Continue ...");
                    Console.ReadKey();
                    Console.Clear();
                    tempName = null;
                }
            } while (string.IsNullOrWhiteSpace(tempName));

            // Set Character Class
            do
            {
                try
                {
                    Console.Write("Character Class: ");
                    tempClass = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(tempClass))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        party[partySize - 1, 1] = tempClass;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Enter Your Character's Class\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to Continue ...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dungeons & Dragons: Party\n");
                    Console.WriteLine($"Character Name: {party[partySize - 1, 0]}");
                }
            } while (string.IsNullOrWhiteSpace(tempClass));

            // Set Character Level
            do
            {
                try
                {
                    Console.Write("Character Level (10-25): ");
                    tempLevel = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(tempLevel))
                    {
                        throw new Exception();
                    }
                    else if (Convert.ToInt16(tempLevel) < 10 || Convert.ToInt16(tempLevel) > 25)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        party[partySize - 1, 2] = tempLevel;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Enter Level between 10 - 25\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to Continue ...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dungeons & Dragons: Party\n");
                    Console.WriteLine($"Character Name: {party[partySize - 1, 0]}");
                    Console.WriteLine($"Character Class: {party[partySize - 1, 1]}");
                    tempLevel = null;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: Enter Your Character's Level\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press Enter to Continue ...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dungeons & Dragons: Party\n");
                    Console.WriteLine($"Character Name: {party[partySize - 1, 0]}");
                    Console.WriteLine($"Character Class: {party[partySize - 1, 1]}");
                    tempLevel = null;
                }
            } while (string.IsNullOrWhiteSpace(tempLevel));

            // Character Creation Completed
            {
                Console.WriteLine($"\nName: {party[partySize - 1, 0]}\t" +
                                  $"Class: {party[partySize - 1, 1]}\t" +
                                  $"Level: {party[partySize - 1, 2]}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCharacter Saved\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press ENTER to continue ...");
                Console.ReadLine();
            }
        }
        static void EditCharacter()
        {
            int characterSelected = 0;
            string tempStoreValue;
            string tempStoreReadLine;
            string editOption;
            bool edit = true;
            do
            {
                // If no Character Created
                if (partySize == 0)
                {
                    Console.WriteLine("Dungeons & Dragons: Party\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: No Character Created\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ENTER to continue ... ");
                    edit = false;
                    Console.ReadKey();
                }
                else // If character(s) Created
                {
                    // Edit Character Select Character
                    do
                    {
                        try
                        {
                            if (partySize == 1)
                            {
                                characterSelected = 1;
                            }
                            else
                            {
                                Console.WriteLine("Dungeons & Dragons: Party\n");
                                Console.Write($"Which character do you want to Edit (1 - {partySize})? ");
                                characterSelected = Convert.ToInt16(Console.ReadLine());
                                if (characterSelected < 1 || characterSelected > partySize)
                                {
                                    throw new Exception();
                                }
                                else if (string.IsNullOrWhiteSpace(characterSelected.ToString()))
                                {
                                    throw new Exception();
                                }
                                Console.Clear();
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nError: No Character Selected\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Press Enter to Continue ...");
                            Console.ReadKey();
                            Console.Clear();
                            characterSelected = 0;
                        }
                    } while (characterSelected == 0);

                    // Edit Character Menu
                    do
                    {
                        Console.Write("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          "Enter: ");
                        editOption = Console.ReadLine();
                        edit = false;
                        switch (editOption)
                        {
                            // Edit Name
                            case "1":
                                do
                                {
                                    tempStoreValue = party[characterSelected - 1, 0];
                                    try
                                    {
                                        Console.Write($"Name: {party[characterSelected - 1, 0]} to ");
                                        tempStoreReadLine = Console.ReadLine();
                                        if (string.IsNullOrWhiteSpace(tempStoreReadLine))
                                        {
                                            throw new Exception();
                                        }
                                        for (int i = 0; i < partySize; i++)
                                        {
                                            if (characterSelected != i + 1 && tempStoreReadLine.ToLower() == party[i, 0].ToLower())
                                            {
                                                throw new ArgumentException();
                                            }
                                        }
                                        party[characterSelected - 1, 0] = tempStoreReadLine;
                                    }
                                    catch (ArgumentException)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nError: Character's Name is Used\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press Enter to Continue ...");
                                        Console.ReadKey();
                                        Console.WriteLine("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        tempStoreReadLine = null;
                                    }
                                    catch (Exception)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nError: Enter Your Character's Name\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press Enter to Continue ...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        tempStoreReadLine = null;
                                    }
                                } while (string.IsNullOrWhiteSpace(tempStoreReadLine));
                                break;
                            // Edit Class
                            case "2":
                                do
                                {
                                    tempStoreValue = party[characterSelected - 1, 1];
                                    try
                                    {
                                        Console.Write($"Class: {party[characterSelected - 1, 1]} to ");
                                        tempStoreReadLine = Console.ReadLine();
                                        if (string.IsNullOrWhiteSpace(tempStoreReadLine))
                                        {
                                            throw new Exception();
                                        }
                                        party[characterSelected - 1, 1] = tempStoreReadLine;
                                    }
                                    catch (Exception)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nError: Enter Your Character's Class\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press Enter to Continue ...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        tempStoreReadLine = null;
                                    }
                                } while (string.IsNullOrWhiteSpace(tempStoreReadLine));
                                break;
                            // Edit Level
                            case "3":
                                do
                                {
                                    tempStoreValue = party[characterSelected - 1, 2];
                                    try
                                    {
                                        Console.Write($"Level: {party[characterSelected - 1, 2]} to ");
                                        tempStoreReadLine = Console.ReadLine();
                                        if (tempStoreReadLine == "")
                                        {
                                            throw new Exception();
                                        }
                                        else if (Convert.ToInt16(tempStoreReadLine) < 10 || Convert.ToInt16(tempStoreReadLine) > 25)
                                        {
                                            throw new ArgumentOutOfRangeException();
                                        }
                                        party[characterSelected - 1, 2] = tempStoreReadLine;
                                    }
                                    catch (ArgumentOutOfRangeException)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error: Enter Level between 10 - 25\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press Enter to Continue ...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.Write("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        Console.WriteLine("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        tempStoreReadLine = null;
                                    }
                                    catch (Exception)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error: Enter Your Character's Level\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Press Enter to Continue ...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Which attribute would you like to edit?\n" +
                                          "1. Name \n" +
                                          "2. Class \n" +
                                          "3. Level \n" +
                                          "B. Back \n\n" +
                                          $"Enter: {editOption}");
                                        tempStoreReadLine = null;
                                    }
                                } while (string.IsNullOrWhiteSpace(tempStoreReadLine));
                                break;
                            // Back to Character Select
                            case "b":
                            case "B":
                                edit = true;
                                Console.Clear();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error: Pick From the Options Provided \n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Press ENTER to Continue ...");
                                Console.ReadKey();
                                Console.Clear();
                                editOption = null;
                                break;
                        }
                        Console.Clear();
                    }
                    while (editOption == null);
                }
            } while (edit);

            editOption = null;
            edit = true;
        }
        static void DeleteCharacter()
        {
            bool deleteCharacter = true;
            string tempStoreReadLine;
            int characterToDelete;
            // If Character Created
            if (partySize > 0)
            {
                do
                {
                    do
                    {
                        if (partySize != 1)
                        {
                            Console.WriteLine("Dungeons & Dragons: Party\n");
                            try
                            {
                                Console.WriteLine("Which Character Do you want to delete? \n");
                                for (int i = 0; i < partySize; i++)
                                {
                                    Console.WriteLine($"{i + 1}: {party[i, 0]}");
                                }
                                Console.Write("\nEnter: ");
                                characterToDelete = Convert.ToInt16(Console.ReadLine());
                                if (characterToDelete < 1 || characterToDelete > partySize)
                                {
                                    throw new Exception();
                                }
                                else if (string.IsNullOrEmpty(characterToDelete.ToString()))
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nError: No Character Selected\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Press Enter to Continue ...");
                                Console.ReadKey();
                                Console.Clear();
                                characterToDelete = 0;
                            }
                        }
                        else
                        {
                            characterToDelete = 1;
                        }
                    } while (characterToDelete == 0);
                    Console.Clear();

                    Console.WriteLine("Dungeons & Dragons: Party\n");
                    Console.WriteLine($"Name: {party[characterToDelete - 1, 0]}\t" +
                                      $"Class: {party[characterToDelete - 1, 1]}\t" +
                                      $"Level: {party[characterToDelete - 1, 2]}\n");
                    Console.Write("Confirm Deletion? (Y / N): ");
                    tempStoreReadLine = Console.ReadLine();
                    switch (tempStoreReadLine)
                    {
                        case "y":
                        case "Y":
                            party[characterToDelete - 1, 0] = null;
                            party[characterToDelete - 1, 1] = null;
                            party[characterToDelete - 1, 2] = null;
                            for (int i = characterToDelete; i < partySize; i++)
                            {
                                party[i - 1, 0] = party[i, 0];
                                party[i - 1, 1] = party[i, 1];
                                party[i - 1, 2] = party[i, 2];
                            }
                            party[partySize - 1, 0] = null;
                            party[partySize - 1, 1] = null;
                            party[partySize - 1, 2] = null;
                            // delete character
                            break;
                        case "n":
                        case "N":
                            break;
                        default:
                            Console.WriteLine("Error: Pick Y or N");
                            break;
                    }
                    deleteCharacter = false;
                } while (deleteCharacter);
                partySize--;
                // are you sure?
                // delete character
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No Character Created\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }
        }
        static void DisplayParty()
        {
            Console.Clear();

            Console.WriteLine("Dungeons & Dragons: Party\n");
            if (partySize > 0)
            {
                for (int i = 0; i < partySize; i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < party.GetLength(1); j++)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Write($"Name: {party[i, j]}\t");
                                break;
                            case 1:
                                Console.Write($"Class: {party[i, j]}\t");
                                break;
                            case 2:
                                Console.Write($"Level: {party[i, j]}\t");
                                break;
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: No Character Created");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\nPress ENTER to continue ...");
            Console.ReadKey();
        }
    }
}