// In the Journal i added an if statement to check if the user typed file name ends with .txt or .csv and also handling case sensitive comparison.  i obtained this resources from https://www.webdevtutor.net/blog/c-sharp-with-end-with

using System;
using System.Collections.Generic;
using System.IO;
namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptGenerator p1 = new PromptGenerator();
            p1._prompt1 = "Who was the most interesting person I interacted with today?";
            p1._prompt2 = "What was the best part of my day?";
            p1._prompt3 = "How did I see the hand of the Lord in my life today?";
            p1._prompt4 = "What was the strongest emotion I felt today?";
            p1._prompt5 = "If I had one thing I could do over today, what would it be?";
            Journal journal = new Journal();
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. quit");
                Console.WriteLine("What would you like to do? ");
                option = int.Parse(Console.ReadLine());
                if (option == 1 || option == 2 || option == 3 || option == 4 || option == 5)
                {
                    if (option == 1)
                    {
                        DateTime theCurrentTime = DateTime.Now;
                        Entry entry = new Entry();
                        entry._date = theCurrentTime.ToShortDateString();
                        entry._promptText = p1.GetGeneratedPrompt();
                        Console.WriteLine(entry._promptText);
                        string readUserPrompt = Console.ReadLine();
                        entry._userResponse = readUserPrompt;
                        journal._entries.Add(entry);
                    }
                    else if (option == 2)
                    {
                        journal.Display();
                    }
                    else if (option == 3)
                    {
                        journal.ReadFromFile();
                    }
                    else if (option == 4)
                    {
                        journal.SaveToFile();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, Please select from 1-5");
                }
            }
        }
    }
}