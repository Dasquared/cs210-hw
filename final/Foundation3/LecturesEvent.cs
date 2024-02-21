using System;

public class LecturesEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LecturesEvent(string title, string description, string date, string time, Address address, string name, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = name;
        _capacity = capacity;
        this.SetType("Lecture");
    }

    public string GetSpeaker()
    {
        return _speakerName;
    }
    public void SetSpeaker(string speaker)
    {
        _speakerName = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    
    public string CreateteFullDetailsLecture()
    {
        string fullDetailed = $"{CreateStandardDetails()} \nSpeaker: {_speakerName} \nTotal Capacity: {_capacity}";
        return fullDetailed;
    }

}