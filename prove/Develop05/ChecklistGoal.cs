using System;

public class ChecklistGoal : Goal
{
    private int _extraPoints;
    private int _times;
    private int _goalTimes;
    public ChecklistGoal() : base()
    {
        _extraPoints = 0;
        _times = 0;
        _goalTimes = 0;
    }

    public int GetTimes()
    {
        return _times;
    }
    public void SetTimes(int times)
    {
        _times = times;
    }
    public int GetGoalTimes()
    {
        return _goalTimes;
    }
    public void SetGoalTimes(int times)
    {
        _goalTimes = times;
    }
    public void SetBonusPoints(int extra)
    {
        _extraPoints = extra;
    }
    public override void CreateGoal()
    {
        Console.Write("What is the name of the goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalShortDes = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _amountOfPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _extraPoints = int.Parse(Console.ReadLine());
    }

    public override string GetList()
    {
        if (_times >= _goalTimes)
        {
            return $". [x] {this.GetName()} ({this.GetDescription()}) -- Currently completed {this.GetTimes()}/{this.GetGoalTimes()}";
        }
        else {
            return $". [ ] {this.GetName()} ({this.GetDescription()}) -- Currently completed {this.GetTimes()}/{this.GetGoalTimes()}";
        }
    }
    public override int RecordEvent()
    {
        this.SetTimes(_times += 1);
        int _newAmount = _amountOfPoints;
        if (_times == _goalTimes)
        {
            _newAmount += _extraPoints;
        }
        Console.WriteLine($"Congratulations! You have earned {_newAmount} points!");
        return _newAmount;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_goalName}~{_goalShortDes}~{_amountOfPoints}~{_extraPoints}~{_goalTimes}~{_times}";
    }
}