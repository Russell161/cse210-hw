using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public override void Run()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(4);
            elapsed += 8;
        }

        DisplayEndMessage();
    }
}
