using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        // _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();

    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresntation()
    {
        throw new NotImplementedException();
    }
}