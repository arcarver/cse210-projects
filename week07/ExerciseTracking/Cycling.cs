public class Cycling : Exercise
{
    private double _speed;
    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double distance = _length * _speed;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length})- Distance {GetDistance()}, Speed {_speed} mph, Pace: {GetPace()} min per mile";
    }
}