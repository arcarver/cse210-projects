public class Cycling : Exercise
{
    private int _speed;
    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        int distance = length * _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        int pace = 60 / _speed;
        return pace;
    }
    public override string GetSummary()
    {
        return $"{date} Running ({length})- Distance {GetDistance()}, Speed {_speed} mph, Pace: {GetPace()} min per mile";
    }
}