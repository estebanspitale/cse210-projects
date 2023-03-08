using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction (int highNumber, int lowNumber)
    {
        _bottom = lowNumber;
        _top = highNumber;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}