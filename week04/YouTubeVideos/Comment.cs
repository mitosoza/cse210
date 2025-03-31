using System;

class Comment
{
    private string _commentUserName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commentUserName = name;
        _commentText = text;
    }

    public string GetDisplayComment()
    {
        return $"{_commentUserName}: {_commentText}";
    }
}