using System.Drawing;

public class Shape
{
    protected string _color;
    public Shape (string color)
    {
        _color = color;
    }
    public string GetColor(string color)
    {
        // SetColor(color);
        Console.WriteLine($"Color is: {color}");
        
        return color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}