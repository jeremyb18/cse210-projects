using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>{};
        shapes.Add(new Square("Red", 2));
        shapes.Add(new Rectangle("Blue", 3,4));
        shapes.Add(new Circle("Yellow", 5));
        shapes.Add(new Quadrilateral("Green", 5,2));
        shapes.Add(new Quadrilateral("Purple", 3));
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.getColor());
            Console.WriteLine(s.getArea());
        }
    }
}