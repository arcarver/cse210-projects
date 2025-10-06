public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
        _name = name;
        name = "Breathing Activity";
        
        
        _description = description;
        description = "This activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing";
       
        _duration = duration;
        
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you throught breathing in and out slowly.  Clear your mind and focus on your breathing.");
        Console.WriteLine();
       
    }
}
