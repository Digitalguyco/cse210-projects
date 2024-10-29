using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Show Score and Level");
            Console.WriteLine("7. Save Goals");
            Console.WriteLine("8. Load Goals");
            Console.WriteLine("9. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    goalManager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a marathon", 1000));
                    break;
                case "2":
                    goalManager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
                    break;
                case "3":
                    goalManager.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple", 50, 10, 500));
                    break;
                case "4":
                    Console.WriteLine("Enter goal number to record:");
                    int goalNumber = int.Parse(Console.ReadLine()) - 1;
                    goalManager.RecordEvent(goalNumber);
                    break;
                case "5":
                    goalManager.DisplayGoals();
                    break;
                case "6":
                    goalManager.DisplayScoreAndLevel();
                    break;
                case "7":
                    Console.WriteLine("Enter file name to save goals:");
                    string fileName = Console.ReadLine();
                    goalManager.SaveGoals(fileName);
                    break;
                case "8":
                    Console.WriteLine("Enter file name to load goals:");
                    fileName = Console.ReadLine();
                    goalManager.LoadGoals(fileName);
                    break;

                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
