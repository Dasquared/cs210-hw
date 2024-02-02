using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _seconds;

    public Activity()
    {
        _name = "Activity";
        _description = "This activity should have a description.";
        _seconds = 10;
    }
    public void DisplaySummary()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _seconds = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        this.PauseWithSpinner(5);
        Console.WriteLine($"\nYou have completed another {_seconds} seconds of {_name}.");
        this.PauseWithSpinner(5);
    }

    public void PauseWithSpinner(int seconds)
    {
        List<string> _animationString = new List<string>();
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= _animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void PauseWithCountdown(int seconds)
    {
        
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        this.PauseWithSpinner(5);
        Console.WriteLine();
    }
}