public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        // string checkbox = "[x]";
        // Console.WriteLine(checkbox);
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresntation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}