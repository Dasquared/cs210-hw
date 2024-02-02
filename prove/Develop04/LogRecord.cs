using System;

public class LogRecord
{
    private int _breathingLog;
    private int _reflectingLog;
    private int _listingLog;

    public LogRecord()
    {
        _breathingLog = 0;
        _reflectingLog = 0;
        _listingLog = 0;
    }

    public int GetBreathingLog()
    {
        return _breathingLog;
    }
    public int GetReflectingLog()
    {
        return _reflectingLog;
    }
    public int GetListingLog()
    {
        return _listingLog;
    }

    public void AddToBreathingLog()
    {
        _breathingLog++;
    }
    public void AddToReflectingLog()
    {
        _reflectingLog++;
    }
    public void AddToListingLog()
    {
        _listingLog++;
    }
}