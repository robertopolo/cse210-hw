using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int optionSelected = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (optionSelected != 0)
        {
            Console.Write("Enter number: ");
            optionSelected = int.Parse(Console.ReadLine());

            if (optionSelected != 0)
            {
                numbers.Add(optionSelected);
            }
        }
        
        //Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Largest number
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        //Smallest positive number
        int smallest = largest;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");

        //Sort list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}