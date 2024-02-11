using System;

public class EternalGoal : Goal
{
    public override string GetList()
    {
        return $". [ ] {this.GetName()} ({this.GetDescription()})";
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_amountOfPoints} points!");
        return _amountOfPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName}~{_goalShortDes}~{_amountOfPoints}";
    }
}