using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>(); 
        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");      
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine($"--- {GetRandomPrompt()}---");
        Console.Write("You may begin in: ");

        ShowCountDown(6);
        Console.Clear();
        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");

    }
    public string GetRandomPrompt()
    {
        int numberOfQuestions = _prompts.Count;
        Random questionSelector = new Random();
        int pos = questionSelector.Next(0, numberOfQuestions);
        string question = "";
        question = _prompts[pos];
        return question;
    }
    public List<string> GetListFromUser()
    {
        int durationLeft = _duration;
        List<string> replyList = new List<string>();

        while (durationLeft > 0)
        {
            replyList.Add(Console.ReadLine());
            // string reply = Console.ReadLine
            // Console.ReadLine()
            Thread.Sleep(10);
            durationLeft = durationLeft - 10;
            _count = replyList.Count;
        }
        return replyList;
    }
}