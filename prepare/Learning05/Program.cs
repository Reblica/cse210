using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("Blue", 2);
        shapes.Add(sq);

        Rectangle re = new Rectangle("Yellow", 3, 6);
        shapes.Add(re);

        Circle ci = new Circle("Green", 7);
        shapes.Add(ci);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}