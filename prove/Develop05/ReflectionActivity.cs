using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private static List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you apply this to other situations?"
    };

    protected override void RunActivity()
    {
        Console.WriteLine("This activity will help you reflect on times when you have shown strength and resilience.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);

        while (DateTime.Now < endTime)
        {
            string selectedQuestion = questions[random.Next(questions.Count)];
            Console.WriteLine(selectedQuestion);
            PauseWithSpinner(5); // Allow 5 seconds for the user to reflect
        }
    }
}
