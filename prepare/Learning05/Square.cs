using System;

public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        double x = _side * _side;
        return x;
    }

    public Square(double side, string color)
    {
        _side = side;
        SetColor(color);
    }
}