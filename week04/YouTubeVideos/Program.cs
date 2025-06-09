using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Intro to C#", "TechGuru", 300);
        v1.AddComment(new Comment("Alice", "Very informative!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Charlie", "Thanks for sharing."));
        videos.Add(v1);

        Video v2 = new Video("Gaming Highlights", "ProGamer", 480);
        v2.AddComment(new Comment("Derek", "Epic moves!"));
        v2.AddComment(new Comment("Ella", "Loved the editing."));
        v2.AddComment(new Comment("Fay", "Can’t wait for the next one!"));
        videos.Add(v2);

        Video v3 = new Video("Travel Vlog: Japan", "Wanderlust", 600);
        v3.AddComment(new Comment("Gina", "This is my dream trip!"));
        v3.AddComment(new Comment("Hank", "Awesome video."));
        v3.AddComment(new Comment("Ivy", "Thanks for the tips!"));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}