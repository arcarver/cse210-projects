public abstract class Exercise
{
    private string _date;
    private int _length;
    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance()
    {
        
    }
    public double GetSpeed()
    {
        return 4;
    }
    public double GetPace()
    {

    }
    public string GetSummary()
    {
        
    }
}