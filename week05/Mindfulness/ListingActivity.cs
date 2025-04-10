using System;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some of your favorite things?",
        "What are some things you are grateful for?",
        "What are some things you are looking forward to?",
        "What are some things you are proud of?",
        "What are some things you are good at?",
        "What are some things you are passionate about?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetResponsesFromUser();
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"--- {prompt} ---");
    }

    public void GetResponsesFromUser()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        _count++;
    }
}