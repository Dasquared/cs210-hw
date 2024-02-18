using  System;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;
    private int numComments;

    public Video()
    {
        _title = "A title";
        _author = "An author";
        _seconds = 0;
        _comments = new List<Comment>();
    }
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetSeconds()
    {
        return _seconds;
    }
    public void SetSeconds(int seconds)
    {
        _seconds = seconds;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }

    private int NumberOfComments()
    {
        numComments = 0;
        foreach (Comment comment in _comments)
        {
            numComments++;
        }
        return numComments;
    }

    

    private void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video: \"{this.GetTitle()}\" by {this.GetAuthor()} - Length in seconds: {this.GetSeconds()}");
        Console.WriteLine($"Number of comments: {this.NumberOfComments()}");
        this.DisplayAllComments();
    }
}