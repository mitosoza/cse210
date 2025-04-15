using System;

public class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}