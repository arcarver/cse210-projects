using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 = new Square();
        square1.GetColor("pink");
        square1.GetArea();

        Circle circle1 = new Circle();
        circle1.GetColor("lilac");
        circle1.GetArea();

        Rectangle rectangle1 = new Rectangle();
        rectangle1.GetColor("Sky Blue");
        rectangle1.GetArea();
    }
}