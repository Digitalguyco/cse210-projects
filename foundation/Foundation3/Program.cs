using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        // Create instances of each activity
        var run = new Running("03 Nov 2022", 30, 4.8);     // 4.8 km run in 30 minutes
        var cycle = new Cycling("03 Nov 2022", 40, 20.0);   // Cycling at 20 km/h for 40 minutes
        var swim = new Swimming("03 Nov 2022", 25, 20);     // 20 laps in 25 minutes

        // Put all activities in a list and display summaries
        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}