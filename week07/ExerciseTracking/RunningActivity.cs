using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / GetMinutes()) * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / _distance, 1);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}