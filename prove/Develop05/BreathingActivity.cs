using System;
using System.Collections.Generic;

public class BreathingActivity : MindfulnessActivity
{
    protected override void RunActivity()
    {
        Console.WriteLine("This activity will help you relax by pacing your breathing. Focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseWithTimer(4);
            Console.WriteLine();
            Console.Write("Now Breathe out...");
            PauseWithTimer(6);
            Console.WriteLine();

        }
    }
}
