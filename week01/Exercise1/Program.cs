using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string fristname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {fristname} {lastname}.");
    }
}