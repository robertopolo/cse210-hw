using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathingActivity.Run();
            }
            else if (userChoice == "2")
            {
                List<string> prompts = new List<string> {"Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need", "Think of a time when you did something truly selfless."};
                List<string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", prompts, questions);
                reflectingActivity.Run();
            }
            else if (userChoice == "3")
            {
                List<string> prompts = new List<string> {"Think of a time when you did something truly selfless", "Think of a time when you helped someone in need", "Think of a time when you stood up for someone else"};
                ListingActivity listingActivity = new ListingActivity("Listing", "List prompts", prompts);
                listingActivity.Run();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}