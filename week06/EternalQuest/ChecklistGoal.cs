using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetPoints()
    {
        int points = 0;
        if (!IsComplete())
        {
            points = int.Parse(_points);
        }
        else if (IsComplete())
        {
            points = int.Parse(_points) + _bonus;
        }
        // pointsS = string.Parse(points);
        return ($"{points}");
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresntation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}