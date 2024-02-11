using System;

public abstract class Shape // adding abstract to line 20 also.
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    // Before we had:
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    //
}