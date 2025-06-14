using System;
using System.Collections.Generic;
using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _itemsListed = new List<string>();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by listing them.")
    {
    }

    public override void Run()
    {
        DisplayStartMessage();
        Console.WriteLine(GetRandomItem(_prompts));
        Console.WriteLine("You may begin in:");
        Countdown(5);

        int duration = GetDuration();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _itemsListed.Add(item);
        }

        stopwatch.Stop();

        Console.WriteLine($"You listed {_itemsListed.Count} items!");
        DisplayEndMessage();
    }

    private string GetRandomItem(List<string> list)
    {
        Random rand = new Random();
        return list[rand.Next(list.Count)];
    }
}
