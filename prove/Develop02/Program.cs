using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Random random = new Random();

        // List of prompts
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(prompt, response, date);
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    // Display journal
                    myJournal.DisplayJournal();
                    break;

                case "3":
                    // Save the journal
                    Console.Write("Enter a filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveJournal(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case "4":
                    // Load the journal
                    Console.Write("Enter a filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadJournal(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case "5":
                    // Quit the program
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
