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
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // public GetTop()
    // {
    //     Console.WriteLine(_top);
    // }
    // public SetTop(int top)
    // {
    //     _top = top;
    // }
    // public GetBottom()
    // {
    //     Console.WriteLine(_bottom);
    // }
    // public SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetFractionValue()
    {
        return  (double) _top / (double) _bottom;
    }
}