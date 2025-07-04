using System;

class Program
{
    
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string userName)
        {
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(string userNumberString)
        {
            Console.WriteLine("Enter your favorite number");
            userNumberString = Console.ReadLine();
            int userNumber = int.Parse(userNumberString);
            return userNumber;
        }

        static int SquareNumber(string squareNumberString)
        {
            Console.WriteLine("Please enter a number to square");
            squareNumberString = Console.ReadLine();
            int squareNumber = int.Parse(squareNumberString);
            return squareNumber;
        }

    static void Main(string[] args)
    {
        DisplayWelcome();

        PromptUserName("");

        PromptUserNumber("");
    }
}