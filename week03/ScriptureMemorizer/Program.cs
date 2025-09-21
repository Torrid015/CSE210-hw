//  THis is a Scripture memorizer program and the requirements exeeded in this program are: 
// Program can randomly select from a library of scriptures, not just one fixed verse.
// User can press Enter to hide words OR type 'quit' to stop anytime.
// Program ensures only visible words get hidden (avoiding wasted random choices)

using System;

 class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.\n");
        Console.ReadLine();

        // Library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Psalm", 23, 1, 4), "The Lord is my shepherd; I shall not want. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me."),
            new Scripture(new Reference("Psalm", 19, 14), "Let the words of my mouth, and the meditation of my heart, be acceptable in thy sight, O Lord, my strength, and my redeemer.."),
            new Scripture(new Reference("Mark", 3, 12), "And he straitly charged them that they should not make him known."),
            new Scripture(new Reference("Act", 1, 7), " And he said unto them, It is not for you to know the times or the seasons, which the Father hath put in his own power.")
        };

        // Pick a random scripture
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }
}