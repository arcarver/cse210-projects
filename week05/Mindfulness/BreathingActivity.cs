using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    { }

    public void Run()
    {
        // added this line to the Activity class.
        // Console.WriteLine("Get ready...");
        DisplayStartingMessage();
        Console.WriteLine();
        while (_duration > 0)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Clear();
            Console.Write("Breath out...");
            ShowCountDown(6);
            Console.Clear();
            _duration = _duration - 10;
        }
        DisplayEndingMessage();
    }
}
