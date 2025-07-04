using System;

class Program
{
    
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int squareNumber = userNumber * userNumber;
            return squareNumber;
        }

    static void DisplayResult(int squareNumber, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);
    }
}