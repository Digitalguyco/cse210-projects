using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Exploring the Python Universe", "John Doe", 600);
        Video video2 = new Video("AI in Modern Technology", "Jane Smith", 720);
        Video video3 = new Video("The Future of Programming", "Alex Johnson", 480);

        // Adding comments to video 1
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "I loved the explanation on classes."));
        video1.AddComment(new Comment("Charlie", "Python is really powerful!"));

        // Adding comments to video 2
        video2.AddComment(new Comment("Dave", "AI will change the world!"));
        video2.AddComment(new Comment("Eve", "Very insightful. Thanks!"));

        // Adding comments to video 3
        video3.AddComment(new Comment("Frank", "Looking forward to the future!"));
        video3.AddComment(new Comment("Grace", "Clear and concise. Thanks for this!"));
        video3.AddComment(new Comment("Hank", "Do more videos on programming!"));

        // Storing all videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate over each video and display their details
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}