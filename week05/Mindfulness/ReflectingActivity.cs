// ================= ReflectingActivity.cs =================
// EXCEEDED REQUIREMENT (uses base class feature): 
// Displays additional reflection questions and integrates 
// the Progress Tracker to show user’s growth over time.

using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you helped someone in need.",
        "Think of a time when you overcame a personal challenge.",
        "Think of a time when you felt truly grateful."
    };

    private List<string> _questions = new List<string> {
        "Why was this meaningful to you?",
        "What did you learn from this experience?",
        "How can you apply this lesson to your daily life?"
    };

    public ReflectingActivity() 
        : base("Reflecting", "This activity will help you reflect on moments of strength and growth.") {}

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nPrompt: " + GetRandomPrompt());
        ShowSpinner(3);

        Console.WriteLine("\nNow consider these questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine("- " + question);
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}