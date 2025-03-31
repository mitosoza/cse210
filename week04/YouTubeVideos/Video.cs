using System;

class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lenght = length;
        _comments = comments;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideoDetails()
    {
        string details = $"Title: {_title}\n";
        details += $"Author: {_author}\n";
        details += $"Length: {_lenght}\n";
        details += $"Number of Comments: {GetNumberOfComments()}\n";
        details += "Comments:\n";

        foreach (Comment comment in _comments)
        {
            details += $" {comment.GetDisplayComment()}\n";
        }

        return details;
    }
}