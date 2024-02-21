using System;

public class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        this.SetType("Outdoor Gathering");
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string CreateFullDetailsOutdoors()
    {
        string fullDetailed = $"{CreateStandardDetails()} \nWeather: It will be {_weather}.";
        return fullDetailed;
    }

}