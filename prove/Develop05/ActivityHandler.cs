using System;

public class ActivityHandler
{
    private List<Goal> _goals;
    private int _totalPointsSaved;
    private string _fileName;
    public ActivityHandler()
    {
        _goals = new List<Goal>();
        _totalPointsSaved = 0;
    }

    public List<Goal> GetListGoals()
    {
        return _goals;
    }

    public void SetListGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public int GetTotalPoints()
    {
        return _totalPointsSaved;
    }
    public void SetTotalPoints(int points)
    {
        _totalPointsSaved = points;
    }
    
    public void SaveFile()
    {
        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_totalPointsSaved}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadFile(string filename)
    {
        _fileName = filename;

        if (File.Exists(_fileName))
        {
            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            int _savedNum = 0;
            foreach (string line in lines)
            {
                if (int.TryParse(line, out _savedNum))
                {
                        _totalPointsSaved = _savedNum;
                }
                else {
                    if (line.Contains("SimpleGoal:"))
                    {
                        string newLine = line.Substring(11);
                        string[] values = newLine.Split('~');
                        SimpleGoal sGoal = new SimpleGoal();
                        sGoal.SetName(values[0]);
                        sGoal.SetDescription(values[1]);
                        sGoal.SetAmountPoints(int.Parse(values[2]));
                        sGoal.SetCompleted(bool.Parse(values[3]));
                        _goals.Add(sGoal);
                        
                    }
                    else if (line.Contains("NegativeGoal:"))
                    {
                        string newLine = line.Substring(13);
                        string[] values = newLine.Split('~');
                        NegativeGoal nGoal = new NegativeGoal();
                        nGoal.SetName(values[0]);
                        nGoal.SetDescription(values[1]);
                        nGoal.SetAmountPoints(int.Parse(values[2]));
                        _goals.Add(nGoal);
                        
                    }
                    else if (line.Contains("EternalGoal:"))
                    {
                        string newLine = line.Substring(12);
                        string[] values = newLine.Split('~');
                        EternalGoal eGoal = new EternalGoal();
                        eGoal.SetName(values[0]);
                        eGoal.SetDescription(values[1]);
                        eGoal.SetAmountPoints(int.Parse(values[2]));
                        _goals.Add(eGoal);
                        
                    }
                    else if (line.Contains("ChecklistGoal:"))
                    {
                        string newLine = line.Substring(14);
                        string[] values = newLine.Split('~');
                        ChecklistGoal cGoal = new ChecklistGoal();
                        cGoal.SetName(values[0]);
                        cGoal.SetDescription(values[1]);
                        cGoal.SetAmountPoints(int.Parse(values[2]));
                        cGoal.SetBonusPoints(int.Parse(values[3]));
                        cGoal.SetGoalTimes(int.Parse(values[4]));
                        cGoal.SetTimes(int.Parse(values[5]));

                        _goals.Add(cGoal);
                        
                    }
                }                 
            }            
        }
    }
}