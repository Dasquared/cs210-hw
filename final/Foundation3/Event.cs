using System;
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "Event";
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public string CreateStandardDetails()
    {
        string standardDetails = $"Title: ||{_title}|| \nDescr: \"{_description}\"\nDate: {_date} at {_time}hs \nWhere: {_address.GetAddress()}";
        return standardDetails;
    }

    public string CreateShortDescription()
    {
        string shortDesc = $"Type of Event: {_type} \nTitle: ||{_title}|| \nDate: {_date} \n";
        return shortDesc;
    }
}