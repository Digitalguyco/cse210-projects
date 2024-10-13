using System;
using System.Collections.Generic;

//  Comment class to track name and text of a comment
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Method to get the comment info
    public string GetCommentInfo()
    {
        return $"{Name}: {Text}";
    }
}
