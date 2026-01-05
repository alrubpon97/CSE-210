using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userLegalName = UserName();
        int userFavNumber = FavNumber();
        int squareNum = SquareNumber(userFavNumber);

        Console.WriteLine($"{userLegalName}, the square of your number is {squareNum}");
    }

    // First function: Displays a welcome message
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Second function: returns the user's legal name
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Third function: returns the user's favorite number
    static int FavNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int a)
    {
        return a * a;
    }
}
