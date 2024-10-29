using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name}: {_description} - Points: {_points} - Completed {_currentCount}/{_targetCount} times";
    }
}


