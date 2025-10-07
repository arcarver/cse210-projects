public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you relect on times in your1 life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of time when you did something truely selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you everdone anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What mad this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {

        DisplayStartingMessage();
        Console.WriteLine();
        int durationLeft = _duration;
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        // using enter to move to next part of program
        ConsoleKeyInfo keyInfo = Console.ReadKey(false);

        while (keyInfo.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("Please press 'Enter' to continue");
        }
        {
            Console.Clear();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("Think about the question: ");
            while (durationLeft > 0)
            {
                DisplayQuestions();
                ShowCountDown(7);
                // Console.Clear();
                durationLeft = durationLeft - 7;
            }
            DisplayEndingMessage();
        }







        // Console.WriteLine();
        // Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        // Console.Write("You may begin in: ");
        // ShowCountDown(4);


        // GetRandomQuestion();

        // while (durationLeft > 0)
        // {
        //     Console.Write($"> {_questions}");
        //     ShowSpinner(7);
        //     durationLeft = durationLeft - 7;
        // }

    }

    public string GetRandomPrompt()
    {
        int numberOfPrompts = _prompts.Count;
        Random promptSelector = new Random();
        int pos = promptSelector.Next(0, numberOfPrompts);
        string prompt = _prompts[pos];
        return prompt;

    }
    public string GetRandomQuestion()
    {
        int numberOfQuestions = _questions.Count;
        Random questionSelector = new Random();
        int pos = questionSelector.Next(0, numberOfQuestions);
        string question = "";
        question = _questions[pos];
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"---{GetRandomQuestion()}---");
    }
}



