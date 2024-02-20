using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public override double GetArea()
    {
        double x = _length * _width;
        return x;
    }
    public Rectangle(double length, double width, string color)
    {
        _length = length;
        _width = width;
        SetColor(color);
    }
}