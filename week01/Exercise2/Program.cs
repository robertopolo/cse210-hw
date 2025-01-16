using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        
        char lastChar = response[response.Length - 1];
        int lastInt = lastChar - 0;
        string sign = "";

        if (lastInt >= 7)
        {
            sign = "+";
        }
        else if (lastInt < 3)
        {
            sign = "-";
        }

        int percentage = int.Parse(response);

        string grade = "";

        if (percentage >= 90)
        {
            grade = $"A{sign}";
        }
        else if (percentage >= 80)
        {
            grade = $"B{sign}";
        }
        else if (percentage >= 70)
        {
            grade = $"C{sign}";
        }
        else if (percentage >= 60)
        {
            grade = $"D{sign}";
        }
        else
        {
            grade = $"F{sign}";
        }

        Console.WriteLine($"Your grade is: {grade}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You don't passed");
        }
    }
}