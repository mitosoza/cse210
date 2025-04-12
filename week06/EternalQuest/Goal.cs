using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool isComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string status = isComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) [Possible points: {_points}]";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}