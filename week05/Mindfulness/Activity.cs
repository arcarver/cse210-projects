public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your sesssion? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
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
            Console.Write("\b \b");
        }
    }
}

