using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
        }
        else
        {
            Console.WriteLine("The goals are:");
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }
    }

    public void CreateGoal(string goalType)
    {
        string name = "";
        string description = "";
        int points = 0;
        int target = 0;
        int bonus = 0;

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
        if (goalType == "checklist")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
        }

        if (goalType == "simple")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalType == "eternal")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "checklist")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
        }
        else
        {
            Console.WriteLine("The goals are:");
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetShortName()}");
                index++;
            }

            Console.Write("Which goal did you accomplish? ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (_goals[goalIndex].isComplete() == true)
            {
                Console.WriteLine("You have already completed this goal.");
            }
            else {
                _goals[goalIndex].RecordEvent();
                _score += _goals[goalIndex].GetPoints();
                Console.WriteLine($"You now have {_score} points.");
            }
        }

    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals saved to {fileName}.");
    }

    public void LoadGoals()
    {
        string fileName = "";
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split('_');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                bool isComplete = bool.Parse(parts[4]);
                simpleGoal.SetIsComplete(isComplete);
                _goals.Add(simpleGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);
                _goals.Add(checklistGoal);
            }
        }

        Console.WriteLine($"Goals loaded from {fileName} successfully.");
    }
}