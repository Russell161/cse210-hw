using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times when you've shown strength and resilience.")
    {
    }

    public override void Run()
    {
        DisplayStartMessage();
        Console.WriteLine(GetRandomItem(_prompts));
        PauseWithSpinner(3);

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine(GetRandomItem(_questions));
            PauseWithSpinner(5);
            elapsed += 5;
        }

        DisplayEndMessage();
    }

    private string GetRandomItem(List<string> list)
    {
        Random rand = new Random();
        return list[rand.Next(list.Count)];
    }
}
