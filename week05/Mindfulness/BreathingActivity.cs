using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    { }

    public void Run()
    {
        // added this line to the Activity class.
        // Console.WriteLine("Get ready...");
        Console.WriteLine();
        while (_duration > 0)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breath out...");
            ShowCountDown(6);
            _duration = _duration - 10;
        }
    }
}
