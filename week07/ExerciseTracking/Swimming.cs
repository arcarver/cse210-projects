using System.ComponentModel.DataAnnotations;

public class Swimming : Exercise
{
    private int _numLaps;
    public Swimming(string date, int length, int numLaps) : base(date, length)
    {
        _numLaps = numLaps;
    }
    public override double GetDistance()
    {
        double distance = _numLaps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double GetSpeed()
    {
        int speed = GetDistance() / length * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetSummary()
    {
        return $"{date} Running ({length})- Distance {GetDistance()}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}