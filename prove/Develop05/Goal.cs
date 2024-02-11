using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalShortDes;
    protected int _amountOfPoints;

    public Goal()
    {
        _goalName = "N/A";
        _goalShortDes = "N/A";
        _amountOfPoints = 0;
    }
    public string GetName()
    {
        return _goalName;
    }
    public void SetName(string name)
    {
        _goalName = name;
    }
    public string GetDescription()
    {
        return _goalShortDes;
    }
    public void SetDescription(string description)
    {
        _goalShortDes = description;
    }

    public int GetAmountPoints()
    {
        return _amountOfPoints;
    }
    public void SetAmountPoints(int points)
    {
        _amountOfPoints = points;
    }
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of the goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalShortDes = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _amountOfPoints = int.Parse(Console.ReadLine());
    }
    
    public abstract string GetList();
    
    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();
}