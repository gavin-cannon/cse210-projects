using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Green", 2);
        Rectangle rectangle1 = new Rectangle("Blue", 2, 4);
        Circle circle1 = new Circle("Yellow", 5);

        string squareColor = square1.GetColor();
        double squareArea = square1.GetArea();
        Console.WriteLine(squareColor);
        Console.WriteLine(squareArea);

        string rectangleColor = rectangle1.GetColor();
        double rectangleArea = rectangle1.GetArea();
        Console.WriteLine();
        Console.WriteLine(rectangleColor);
        Console.WriteLine(rectangleArea);

        string circleColor = circle1.GetColor();
        double circleArea = circle1.GetArea();
        Console.WriteLine();
        Console.WriteLine(circleColor);
        Console.WriteLine(circleArea);
        Console.WriteLine();


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}