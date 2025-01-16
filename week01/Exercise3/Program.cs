using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string repeat = "";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 21);
            int userGuess = -1;
            int rounds = 0;

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                rounds += 1;

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {rounds} attempts.");
            Console.WriteLine("Play again?: 1.Yes 2.No");
            repeat = Console.ReadLine();
        }
        while (repeat == "1");
    }
}