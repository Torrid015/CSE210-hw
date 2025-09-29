// ================= ListingActivity.cs =================
// EXCEEDED REQUIREMENT: 
// Counts how many responses the user listed and displays 
// the total at the end in addition to the Progress Tracker.

using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?"
    };

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on good things in your life by listing them.") {}

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        List<string> responses = new List<string>();
        Console.WriteLine("Start listing (press Enter after each, blank line to stop):");

        string input;
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                responses.Add(input);
        } while (!string.IsNullOrEmpty(input));

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}