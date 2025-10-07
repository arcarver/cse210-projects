using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing")
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
