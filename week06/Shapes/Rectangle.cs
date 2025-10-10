using System.Formats.Asn1;

public class Rectangle : Shape
{
    protected double _length;
    protected double _width;
    public Rectangle() : base("teal")
    {
        _width = 7;
        _length = 2;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        Console.WriteLine($"The area of the rectangle is: {area}");
        return area;
    }
}