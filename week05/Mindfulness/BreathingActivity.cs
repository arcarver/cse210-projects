using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    { }

    public void Run()
    {
        // added this line to the Activity class.
        // Console.WriteLine("Get ready...");
        DisplayStartingMessage();
        Console.WriteLine();
        int durationLeft = _duration;
        while (durationLeft > 0)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Clear();
            Console.Write("Breath out...");
            ShowCountDown(6);
            Console.Clear();
            durationLeft = durationLeft - 10;
        }
        DisplayEndingMessage();
    }
}
