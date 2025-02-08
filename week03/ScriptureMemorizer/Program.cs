using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText() + " " + scripture.GetDisplayText());
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine().ToLower();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords(1);
                count++;
            }
            else if (input == "quit")
            {
                break;
            }
        }
    }
}