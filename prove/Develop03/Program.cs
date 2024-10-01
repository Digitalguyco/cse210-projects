using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        // Main loop
        while (true)
        {
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden. The program will now exit.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }
    }
}
