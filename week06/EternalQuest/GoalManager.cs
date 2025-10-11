using System.Security.Cryptography.X509Certificates;
using System.IO;

public class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    public int _score;
    public GoalManager(int score, List<Goal> goals)
    {
        _score = score;
        _goals = goals;
    }
    public void Start() { }
    // Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.

    public void DisplayPlayerInfo()
    {
        // DisplayPlayerInfo - Displays the players current score.
        Console.WriteLine($"Your score is {_score}");
    }
    public void ListGoalNames(string name)
    {
        // ListGoalNames - Lists the names of each of the goals.
        Console.Write($"Your Goal is called: {name}");
    }
    public void ListGoalDetails() { }
    // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    public void CreateGoal() { }
    // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    public void RecordEvent() { }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void SaveGoals()
    {
        // SaveGoals - Saves the list of goals to a file.
        // Console.Write("What is the ffilename for the goal file? ");
        // string fileName = Console.ReadLine();

        // using (StreamWriter outputFile = new StreamWriter(fileName))
        // {
        //     outputFile.WriteLine(_score);

        //     // for (int i = 0; i < lines.Length; ++i)
            
        //         outputFile.WriteLine(GetStringRepresntation());
            
        // }

    }
    public void LoadGoals()
    {
        // LoadGoals - Loads the list of goals from a file.
        // Console.WriteLine("What is the name of the file you would like to load? ");
        // string loadFileName = Console.ReadLine();
        // string[] lines = System.IO.File.ReadAllLines(loadFileName);
        // string sscore = lines[0];
        // for (int i = 1; i < lines.Length; ++i)
        // {
        //     string line = lines[i];
        //     string[] parts = line.Split(",");

        //     string goalType = parts[0];
        //     string goalName = parts[1];
        //     string goalDescription = parts[2];
        //     string pointsToEarn = parts[3];
        //     if (parts[0] == "SimpleGoal")
        //     {
        //         string finished = parts[4];
        //     }
        //     else if (parts[0] == "ChecklistGoal")
        //     {
        //         string bonusPoints = parts[4];
        //         string timeToDoGoal = parts[5];
        //         string timesDone = parts[6];
        //     }
        //     else
        //     { }

        // }



    }
}