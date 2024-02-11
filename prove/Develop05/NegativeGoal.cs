using System;

public class NegativeGoal : Goal // This is a part that exceeds requirements.
{

    public override void CreateGoal()
    {
        Console.Write("What is the name of the negative goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalShortDes = Console.ReadLine();
        Console.Write("What is the amount of points you want to lose with this goal? ");
        _amountOfPoints = int.Parse(Console.ReadLine());
    }
    public override string GetList()
    {
        return $". [ ] {this.GetName()} ({this.GetDescription()})";
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"My condolences! You have lost {_amountOfPoints} points!");
        return -_amountOfPoints;
    }
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_goalName}~{_goalShortDes}~{_amountOfPoints}";
    }
}