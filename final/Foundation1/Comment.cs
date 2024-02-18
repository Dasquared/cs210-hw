using System;

public class Comment
{
    private string _name;
    private string _textComment;

    public Comment()
    {
        _name = "Unknown";
        _textComment = "N/A";
    }
    public Comment(string name, string text)
    {
        _name = name;
        _textComment = text;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetTextComment()
    {
        return _textComment;
    }

    public void SetTextComment(string text)
    {
        _textComment = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name} commented: \"{_textComment}\"");
    }
}