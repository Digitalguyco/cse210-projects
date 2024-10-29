using System;
public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;
    private int _level;
    private const int PointsPerLevel = 1000; // Points needed to level up

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
        _level = 1;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _totalScore += _goals[goalIndex].RecordEvent();
            CheckLevelUp(); // Check if the user levels up
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_totalScore / PointsPerLevel) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"\nCongratulations! You've leveled up to Level {_level}!");
            // Optional: Add a reward system, special message, or new feature unlocks here.
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayScoreAndLevel()
    {
        Console.WriteLine($"Total Score: {_totalScore} | Level: {_level}");
    }

        // Save goals and score to a file
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_totalScore);
            writer.WriteLine(_level);

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }

        Console.WriteLine("Goals and score have been saved.");
    }

    //load goals
    public void LoadGoals(string filePath)
{
    if (File.Exists(filePath))
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            _totalScore = int.Parse(reader.ReadLine());
            _level = int.Parse(reader.ReadLine());

            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                _goals.Add(Goal.Deserialize(line));
            }
        }

        Console.WriteLine("Goals and score have been loaded.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}

}
