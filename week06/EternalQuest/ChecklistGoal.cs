using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        if (isComplete())
        {
            _points += _bonus;
            Console.WriteLine($"You have completed the goal and earned a bonus of {_bonus} points!");
        }
    }

    public override bool isComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string status = isComplete() ? "[X]" : "[ ]";
        int originalPoints = isComplete() ? _points - _bonus : _points;
        return $"{status} {_shortName} ({_description}) [Possible Points {originalPoints}, Bonus {_bonus}] -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal_{_shortName}_{_description}_{_points}_{_amountCompleted}_{_target}_{_bonus}";
    }
}