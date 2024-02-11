using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 2);
        Rectangle r1 = new Rectangle("red", 2, 4);
        Circle c1 = new Circle("yellow", 1);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}