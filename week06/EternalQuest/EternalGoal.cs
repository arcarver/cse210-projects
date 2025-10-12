public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        // Eternal goal never completes
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresntation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}