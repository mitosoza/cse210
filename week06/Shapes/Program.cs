using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("blue", 3, 5);
        Circle circle = new Circle("yellow", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape has a color: {shape.GetColor()}, and area: {shape.GetArea()}");
        }
    }
}