using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square () : base("yellow")
    {
        _side = 3;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        Console.WriteLine($"The area of the square is: {area}");
        return area;
    }
}