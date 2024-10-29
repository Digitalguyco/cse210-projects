public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name}: {_description} - Points: {_points}";
    }

    public bool IsComplete() => _isComplete;

    public virtual string Serialize()
    {
        return $"{GetType().Name}|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);

        Goal goal = type switch
        {
            "SimpleGoal" => new SimpleGoal(name, description, points),
            "EternalGoal" => new EternalGoal(name, description, points),
            "ChecklistGoal" => new ChecklistGoal(name, description, points, int.Parse(parts[5]), int.Parse(parts[6])),
            _ => throw new ArgumentException("Unknown goal type")
        };

        goal._isComplete = isComplete;
        return goal;
    }
}
