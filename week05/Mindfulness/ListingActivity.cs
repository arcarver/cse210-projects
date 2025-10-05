public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(int count, List<string> promptlist, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = promptlist;
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    { }
    public void GetRandomPrompt()
    { }
    public List<string> GetListFromUser()
    {
        return null;
    }
}