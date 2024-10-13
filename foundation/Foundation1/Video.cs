using System;
using System.Collections.Generic;
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }  // Length in seconds
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display the video information along with comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"  {comment.GetCommentInfo()}");
        }
        Console.WriteLine(new string('-', 30));
    }
}
