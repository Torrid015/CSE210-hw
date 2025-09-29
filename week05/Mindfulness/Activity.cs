// ================= Activity.cs =================
// EXCEEDED REQUIREMENT: 
// Added a "Progress Tracker" feature using a static dictionary 
// to count how many times each activity has been completed. 
// This goes beyond the basic requirements by keeping track of 
// the user’s progress across different activities.

using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Track how many times each activity has been completed
    protected static Dictionary<string, int> _activityCounter = new Dictionary<string, int>();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        if (!_activityCounter.ContainsKey(_name))
        {
            _activityCounter[_name] = 0;
        }
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n=== {_name} Activity ===");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        _activityCounter[_name]++; // update progress tracker

        Console.WriteLine($"\nWell done! You completed the {_name} Activity.");
        Console.WriteLine($"You spent {_duration} seconds practicing mindfulness.");

        // Show progress tracker
        Console.WriteLine("\n📊 Progress Tracker:");
        foreach (var entry in _activityCounter)
        {
            Console.WriteLine($"   {entry.Key}: {entry.Value} time(s)");
        }

        Console.WriteLine("\nTake a moment to feel good about what you accomplished.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|"); Thread.Sleep(300);
            Console.Write("\b/"); Thread.Sleep(300);
            Console.Write("\b-"); Thread.Sleep(300);
            Console.Write("\b\\"); Thread.Sleep(300);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}