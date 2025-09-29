// ================= Program.cs =================
// EXCEEDED REQUIREMENT (menu design): 
// Added a clean menu system that lets the user repeat activities, 
// and integrates the new Progress Tracker from the base class.

using System;

class Program
{
    static void Main()
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("\n=== Mindfulness Program ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                new BreathingActivity().Run();
            else if (choice == 2)
                new ListingActivity().Run();
            else if (choice == 3)
                new ReflectingActivity().Run();
        }
        Console.WriteLine("\nThanks for practicing mindfulness today!");
    }
}