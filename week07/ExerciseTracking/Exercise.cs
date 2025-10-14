public abstract class Exercise
{
    protected string _date;
    protected double _length;
    public Exercise(string date, double length)
    {
        _date = date;
        _length = length;
        // Exercise excecise2 = new Exercise("Oct 31, 2024", 5);
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
 
}