using System.Security.Cryptography.X509Certificates;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(int score, List<Goal> goals)
    {
        _score = score;
        _goals = goals;
    }
    public void Start()
    {
        // Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        bool finish = false;
        while (finish != true)
        {
            Console.WriteLine("Welcome to the 'Eternal Quest Game!");
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Create New Goals");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Save and Quit");
            Console.WriteLine("   7. Quit");
            string option = Console.ReadLine();
            if (option == "1")
            {

            }
            else if (option == "2")
            {
                ListGoalNames();
            }
            else if (option == "3")
            {
                SaveGoals();
            }
            else if (option == "4")
            {
                LoadGoals();
            }
            else if (option == "5")
            {

            }
            else if (option == "6")
            {
                Console.WriteLine("Thank you for playing Eternal Quest!");
                SaveGoals();
                Console.WriteLine("Your goals have been saved.");
                finish = true;


            }
            else if (option == "7")
            {
                Console.WriteLine("Thank you for playing Eternal Quest!");
                finish = true;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        // DisplayPlayerInfo - Displays the players current score.
        Console.WriteLine($"Your score is {_score}");
    }
    public void ListGoalNames()
    {
        // ListGoalNames - Lists the names of each of the goals.
        foreach (Goal goalInstance in _goals)
        {
            string name = goalInstance.GetNameString();
            Console.Write(name);
        }
    }
    public void ListGoalDetails()
    {
        // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
        foreach (Goal goalInstance in _goals)
        {
            string details = goalInstance.GetDetailsString();
            if (goalInstance.IsComplete())
            {
                Console.WriteLine($"[ ] {details}");
            }
            else
            {
                Console.WriteLine($"[X] {details}");
            }
        }
    }
    public void CreateGoal() { }
    // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    public void RecordEvent() { }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void SaveGoals()
    {
        // SaveGoals - Saves the list of goals to a file.
        Console.Write("What is the ffilename for the goal file? ");
        // string fileName = Console.ReadLine();
        string fileName = "a.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goalInstance in _goals)
            {
                outputFile.WriteLine(goalInstance.GetStringRepresntation());
            }
        }

    }
    public void LoadGoals()
    {
        _goals = new List<Goal>();
        // LoadGoals - Loads the list of goals from a file.
        Console.WriteLine("What is the name of the file you would like to load? ");
        // string loadFileName = Console.ReadLine();
        string loadFileName = "a.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFileName);
        string sscore = lines[0];
        for (int i = 1; i < lines.Length; ++i)
        {
            string line = lines[i];
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            string pointsToEarn = parts[3];
            if (goalType == "SimpleGoal")
            {
                string finished = parts[4];
                SimpleGoal simpleGoalInstance = new SimpleGoal(goalName, goalDescription, pointsToEarn);
                if (finished == "true")
                {
                    simpleGoalInstance.RecordEvent();
                }
                _goals.Add(simpleGoalInstance);
            }
            else if (goalType == "ChecklistGoal")
            {
                string bonusPoints = parts[4];
                string timeToDoGoal = parts[5];
                string timesDone = parts[6];
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalName, goalDescription, pointsToEarn));
            }

        }



    }
}