using System;

public class Circle : Shape
{
    private double _radius;
    public override double GetArea()
    {
        double x = _radius * _radius * 3.14;
        return x;
    }
    public Circle(double radius, string color)
    {
        _radius = radius;
        SetColor(color);
    }
}
