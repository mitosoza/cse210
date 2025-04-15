using System;

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, double minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetMinutes()) * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 1);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}