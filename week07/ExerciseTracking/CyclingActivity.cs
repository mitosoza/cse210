using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double GetDistance()
    {
        return Math.Round((_speed / 60) * GetMinutes(), 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 1);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}