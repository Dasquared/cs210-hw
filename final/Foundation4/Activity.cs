using System;

public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _activityName;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance().ToString("0.0")} miles, Speed: {GetSpeed().ToString("0.0")} mph, Pace: {GetPace().ToString("0.0")} min per mile";
    }
}