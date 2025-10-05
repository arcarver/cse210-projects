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
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }
}

