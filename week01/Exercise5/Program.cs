using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string username = PromptUsername();
        int favouriteNumber = PromptNumber();
        int square = SquaredNumber(favouriteNumber);
        DisplayDetails(username, square);

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program.");
        }

        static string PromptUsername()
        {
            Console.Write("Please, Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptNumber()
        {
            Console.Write("Please, Enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayDetails(string username, int square)
        {
            Console.Write($"{username}, the square of your number is: {square}");
        }
    }
}