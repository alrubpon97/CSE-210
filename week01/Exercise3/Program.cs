using System;

class Program
{
    static void Main(string[] args)
    {
        // The user assigns the magic number
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = 0;

        while (guess != magicNumber)
        {
             // The user gueses a number
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        } 
    }
}