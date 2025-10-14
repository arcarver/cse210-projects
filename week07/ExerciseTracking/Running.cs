using System.ComponentModel.DataAnnotations;

public class Running : Exercise
{
    private int _distance;

    public Running(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance() 
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / _length;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        return $"{date} Running ({length})- Distance {_distance}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
