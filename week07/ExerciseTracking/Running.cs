using System.ComponentModel.DataAnnotations;

public class Running : Exercise
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        
    }
    public override double GetDistance() 
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = 60 * (_distance / _length);
        return speed;
        // return 60 * (_distance / _length);
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length})- Distance {_distance}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
