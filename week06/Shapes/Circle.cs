




public class Circle : Shape
{
    protected double _radius;

    public Circle() : base()
    {
    }
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}