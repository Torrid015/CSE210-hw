using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create first video and add comments

        Video video1 = new Video("Learning C#", "Odunayo", 300);
        video1.AddComment(new Comment("Bimbo", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Mercy", "Great Tutorial!"));
        video1.AddComment(new Comment("James", "I learned a lot."));
        videos.Add(video1);

        // Create second video and add comments

        Video video2 = new Video("Learning C#", "Torrid", 450);
        video2.AddComment(new Comment("Mac", "Wow! One of the best tutorial i've seen on here."));
        video2.AddComment(new Comment("Chison", "Thank you very much for making this tutorial free."));
        video2.AddComment(new Comment("Adrain", "Best teacher ever."));
        videos.Add(video2);

        // Create third video and add comments

        Video video3 = new Video("How to draft patterns for native trousers", "Shantel", 600);
        video3.AddComment(new Comment("Mike", "Your design patterns are so useful."));
        video3.AddComment(new Comment("Karen", "Thanks for the clear explanations."));
        video3.AddComment(new Comment("John", "Looking forward to more videos like this, thank you."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}