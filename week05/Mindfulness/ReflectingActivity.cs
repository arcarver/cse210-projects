public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    { }
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