using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        // Loop that runs until the user types 0
        while (userNumber != 0)
        {
            numbers.Add(userNumber);
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
        }
        
        if (numbers.Count > 0)
        {
            int totalSum = numbers.Sum();
            double averageNumber = numbers.Average();
            int largestNumber = numbers.Max();

            Console.WriteLine($"The sum is: {totalSum}");
            Console.WriteLine($"The average is: {averageNumber}");
            Console.WriteLine($"The largest number is: {largestNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }    
    }
}