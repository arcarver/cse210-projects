public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        //  name of activity
        _name = name;
        name = "Name of Activity";
        // description of activity
        _description = description;
        description = "This is a description of the activity";
        // how long in seconds the activty lasts
        _duration = duration;
        duration = 30;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your sesssion? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(5000);
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            // This doesn't work under debugger
            // Run without debugger using Ctrl+F5
            // Console.Write("\b\b  \b\b");
        }
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerString = new List<string>();
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerString[i];
            Console.Write(s);
            Thread.Sleep(400);
            // This doesn't work under debugger
            // Run without debugger using Ctrl+F5
            Console.Write("\b \b");

            i++;
            if (i >= spinnerString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            // This doesn't work under debugger
            // Run without debugger using Ctrl+F5
            Console.Write("\b\b  \b\b");
        }
    }
}

