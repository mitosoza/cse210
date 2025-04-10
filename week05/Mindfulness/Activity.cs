using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30;
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> animationString =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}