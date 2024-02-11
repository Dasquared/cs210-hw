using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal() : base()
    {
        _isCompleted = false;
    }
    public void SetCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public override string GetList()
    {
        if (_isCompleted)
        {
            return $". [x] {this.GetName()} ({this.GetDescription()})";
        }
        else {
            return $". [ ] {this.GetName()} ({this.GetDescription()})";
        }
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations! You have earned {_amountOfPoints} points!");
        return _amountOfPoints;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_goalName}~{_goalShortDes}~{_amountOfPoints}~{_isCompleted}";
    }
}