using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Green", 2);
        string squareColor = square1.GetColor();
        double squareArea = square1.GetArea();
        Console.WriteLine(squareColor);
        Console.WriteLine(squareArea);
    }
}