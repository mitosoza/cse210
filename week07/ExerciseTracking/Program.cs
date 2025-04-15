using System;

class Program
{
    static void Main(string[] args)
    {
        string today = DateTime.Now.ToString("dd MMM yyyy");
        string oneDayAgo = DateTime.Now.AddDays(-1).ToString("dd MMM yyyy");
        string twoDaysAgo = DateTime.Now.AddDays(-2).ToString("dd MMM yyyy");

        RunningActivity runningActivity = new RunningActivity(today, 30, 3);
        CyclingActivity cyclingActivity = new CyclingActivity(oneDayAgo, 30, 16);
        SwimmingActivity swimmingActivity = new SwimmingActivity(twoDaysAgo, 60, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}