public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _name = "Reflecting Activity";
        _description = "This activity will help you relect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
        _duration = duration;
    }
    public void Run()
    {
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
    public string GetRandomPrompt()
    {
        return "";
        }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    { }
    public void DisplayQuestions()
    {}
}