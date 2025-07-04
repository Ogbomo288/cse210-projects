using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool addNumber = true;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (addNumber)
        {
            Console.WriteLine("Enter number:");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                addNumber = false;
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        int max = numbers.Max();
        Console.WriteLine($"Your number list: {max}");
    }
}