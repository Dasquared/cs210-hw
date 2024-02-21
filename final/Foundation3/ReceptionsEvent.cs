using System;

public class ReceptionEvent : Event
{
    private string _email;
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
        this.SetType("Reception");
    }

    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }

    public string CreateFullDetailsReception()
    {
        string fullDetailed = $"{CreateStandardDetails()} \nRSVP: {_email}";
        return fullDetailed;
    }
}