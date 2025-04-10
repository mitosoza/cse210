using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int randomTimeIn = new Random().Next(3, 6);
            int randomTimeOut = new Random().Next(3, 6);

            Console.Write("\nBreathe in...");
            ShowCountDown(randomTimeIn);

            Console.Write("\nNow breathe out...");
            ShowCountDown(randomTimeOut);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}