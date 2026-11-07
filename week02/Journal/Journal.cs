using System;
using System.Collections.Generic;
namespace Journal
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void Display()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile()
        {
            Console.WriteLine("What is the filename? ");
            string fileName = Console.ReadLine();

            if (fileName.EndsWith(".txt") || fileName.EndsWith(".csv"))
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry en in _entries)
                    {
                        string savedDate = en._date;
                        string savedPrompt = en._allGeneratedOutputs;
                        string savedInputPrompt = en._allStoredInputs;
                        outputFile.WriteLine($"{savedDate},{savedPrompt},{savedInputPrompt}");
                    }
                }
                Console.WriteLine("File saved successfully....");
            }
            else
            {
                Console.WriteLine("Invalid file extensions format");
            }
        }
        public void ReadFromFile()
        {
            Console.WriteLine("What is the filename? ");

            string fileName = Console.ReadLine();
            if (fileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Entry en = new Entry();
                        en._date = parts[0];
                        en._allGeneratedOutputs = parts[1];
                        en._allStoredInputs = parts[2];
                        _entries.Add(en);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid file extensions format");
            }
            Console.WriteLine("File  successfully loaded");
        }
    }
}