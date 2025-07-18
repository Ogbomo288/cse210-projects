using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select on of the following choices");

        static void DisplayMenu()
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
        }
        
        Journal theJournal = new Journal();

        PromptGenerator thePrompthGenerator = new PromptGenerator();

        string choice = "";
        
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        while (choice != "5")
        {
            DisplayMenu();
            Console.Write("What do you want to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                string selectedPrompt = thePrompthGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {selectedPrompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Entry anEntry = new Entry();
                anEntry._promptText = selectedPrompt;
                anEntry._date = dateText;
                anEntry._entryText = response;

                theJournal.AddEntry(anEntry);
                Console.WriteLine("");

            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the filename");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }

            else if (choice == "5")
            {
                break;
            }
        }


        
    }
}