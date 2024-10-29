using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration; // Duration in seconds

    // Method to start the activity
    public void StartActivity()
    {
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine(GetStartingDescription());
        SetDuration();
        PrepareToStart();
        RunActivity();
        ShowEndingMessage(); 
    }

    // Abstract method to run the specific activity
    protected abstract void RunActivity();

    // Method to get the starting message (shared)
    private string GetStartingMessage()
    {
        return $"\nWelcome to the {this.GetType().Name}.\n";
    }

    private string GetStartingDescription()
    {
        string name = this.GetType().Name;
        switch (name)
        {
            case "BreathingActivity":
                return "This activity will help you relax by pacing your breathing. Focus on your breathing.\n";
            case "ReflectionActivity":
                return "This activity will help you reflect on times when you have shown strength and resilience.";
            case "ListingActivity":
                return "This activity will help you reflect on the good things in your life.";
            default:
                return "";
        }
    }

    // Method to set duration
    private void SetDuration()
    {
        Console.Write("How long, in seconds you like for session? ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    // Method to prepare before starting
    private void PrepareToStart()
    {
        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3); // Pauses for 3 seconds before starting
    }

    // Method to show ending message
    private void ShowEndingMessage()
    {
        Console.WriteLine($"\nGood job! You've completed {this.GetType().Name} for {duration} seconds.");
        PauseWithSpinner(3); // Pauses for 3 seconds after completion
    }

    // Method to pause with spinner
    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b\b");
        }
    }

     // Method to pause with Timer
    protected void PauseWithTimer(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - (i+1));
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("");
        }
    }
}

