// ================= BreathingActivity.cs =================
// EXCEEDED REQUIREMENT (uses base class feature): 
// Integrated the new Progress Tracker to count completions 
// and display stats at the end of the activity.

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing in and out.") {}

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}