public class Circle : Shape
{
    protected double _radius;

    public Circle() : base("green")
    {
        _radius = 5;
    }
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        Console.WriteLine($"The area od the circle is: {area}");
        return area;
    }
}