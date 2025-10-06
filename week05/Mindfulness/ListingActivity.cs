public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(int count, List<string> promptlist, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = promptlist;
        _name = "Listing Activity";
        _description = ;
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
    public void GetRandomPrompt()
    { }
    public List<string> GetListFromUser()
    {
        return null;
    }
}