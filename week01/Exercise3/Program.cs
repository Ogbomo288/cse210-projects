using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate random number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        bool guessAgain = true;
        int numberOfGuess = 0;

        while (guessAgain)
        {

            numberOfGuess = numberOfGuess + 1;
            Console.WriteLine("What is your guess?");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);


            if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine("You guessed right");
                guessAgain = false;
            }
        }
        Console.WriteLine($"You guess {numberOfGuess} times");
    }
}