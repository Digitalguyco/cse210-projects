using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private static List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    protected override void RunActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life.");

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);

        Console.WriteLine("Start listing items...");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}
