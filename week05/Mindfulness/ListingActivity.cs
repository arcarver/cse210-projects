public class ListingActivity
{
    private int _count;
    private List<Prompts> _prompts = new List<Prompts>();

    public ListingActivity(int count, List<Prompts> promptlist)
    {
        _count = count;
        _prompts = promptList;
    }
    public void Run()
    { }
    public void GetRandomPrompt()
    { }
    public List<string> GetListFromUser()
    {}
}