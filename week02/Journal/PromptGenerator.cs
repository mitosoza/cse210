using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "What is something I am grateful for today?",
        "What was a challenge you faced today?",
        "Describe a moment that made you smile?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}