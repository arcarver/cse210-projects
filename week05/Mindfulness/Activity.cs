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
        Console.WriteLine($"You have completed another {_duration} of the {_name}.");
        Thread.Sleep(5000);
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

        foreach (string s in spinnerString)
        {
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
    }
}

