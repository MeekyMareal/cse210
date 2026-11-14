using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        int top = _numerator;
        int bottom = _denominator;
        string show = $"{top} / {bottom}";
        return show;
    }

    public double GetDecimalValue()
    {
        double divide = _numerator / _denominator;
        return divide;
    }
}