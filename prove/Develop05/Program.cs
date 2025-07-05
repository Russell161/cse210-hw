using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== Eternal Quest ====");
            Console.WriteLine($"Total Score: {totalPoints} points\n");

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("\nChoose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal (one-time)");
        Console.WriteLine("2. Eternal Goal (repeatable)");
        Console.WriteLine("3. Checklist Goal (multiple times with bonus)");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points awarded: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, target));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        if (goals.Count == 0) return;

        Console.Write("\nWhich goal did you accomplish? (Enter number): ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= goals.Count)
        {
            int earned = goals[index - 1].RecordEvent();
            totalPoints += earned;
            Console.WriteLine($"Recorded! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalPoints);
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.SaveData());
            }
        }

        Console.WriteLine("Goals and score saved successfully.");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            goals.Add(Goal.LoadData(lines[i]));
        }

        Console.WriteLine("Goals and score loaded successfully.");
    }
}
