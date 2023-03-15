using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 5);
        Rectangle rectangle1 = new Rectangle("Green", 5, 62);
        Circle circle1 = new Circle("Mauve", 50);
        
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape i in shapes){
            string color = i.GetColor();
            double area = i.GetArea();
            Console.Write($"{color} ");
            Console.WriteLine(area);
        }

    }
}