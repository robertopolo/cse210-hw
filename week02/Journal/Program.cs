using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        while (true)
        {
            string optionSelected;

            Console.WriteLine("\n------> Welcome to the Journal program <-----\n");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            optionSelected = Console.ReadLine();
            
            if (optionSelected == "1")
            {
                Entry entry = new Entry();
                string promptGenerated = prompt.GetRandomPrompt();
                Console.WriteLine($"\n{promptGenerated}");
                string entryUser = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._promptText = promptGenerated;
                entry._date = dateText;
                entry._entryText = entryUser;
                journal.AddEntry(entry);
            }
            else if (optionSelected == "2")
            {
                journal.DisplayAll();
            }
            else if (optionSelected == "3")
            {
                Console.WriteLine("What is the filename?");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (optionSelected == "4")
            {
                Console.WriteLine("What is the filename?");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (optionSelected == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            Console.WriteLine("Invalid choice\n");
        }
    }
}