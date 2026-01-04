using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string user_grade = Console.ReadLine();
        int user_grade_int = int.Parse(user_grade);

        string letter = "";

        if (user_grade_int >= 90)
        {
            letter = "A";

        }
        else if (user_grade_int >= 80)
        {
            letter = "B";
        }
        else if (user_grade_int >= 70)
        {
            letter = "C";
        }
        else if (user_grade_int >= 60) {
            letter = "D";
        } 
        else {
            letter = "F";
        }

        string sign = "";
        int lastDigit = user_grade_int % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");
        if (user_grade_int >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}