using System;

class Program
{
    static void Main(string[] args)
    {

        Circle circle = new Circle(3, "blue");
        Rectangle rectangle = new Rectangle(4,5,"red");
        Square square = new Square(5,"yellow");

        List<Shape> _shapes = new List<Shape>{circle,rectangle,square};
        foreach (Shape i in _shapes)
        {
            Console.WriteLine(i.GetColor());
            Console.WriteLine(i.GetArea());
            Console.WriteLine(" ");
        }
    }
}