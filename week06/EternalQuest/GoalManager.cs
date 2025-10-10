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
        Console.WriteLine($"Your score is {score}");
    }
    public void ListGoalNames() { }
    // ListGoalNames - Lists the names of each of the goals.
    public void ListGoalDetails() { }
    // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    public void CreateGoal() { }
    // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    public void RecordEvent() { }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void SaveGoals(int score, List<Goal> goals)
    {
        // SaveGoals - Saves the list of goals to a file.
        Console.Write("What is the ffilename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(score);
            
                foreach (Goal g in goals)
                {
                outputFile.WriteLine();
                }
        }
    
    }
    public void LoadGoals() {
        // LoadGoals - Loads the list of goals from a file.
        Console.WriteLine("What is the name of the file you would like to load? ");
        string loadFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFileName);

        lines[0] = score;
        foreach (string line in lines)
        {
            
            string[] firstLine = line.Skip(1);
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            string pointsToEarn = parts[3];
            if (parts[0] == "SimpleGoal")
            {
                string finished = parts[4];
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string bonusPoints = parts[4];
                string timeToDoGoal = parts[5];
                string timesDone = parts[6];
            }
            else
            {}

        }
        

        
    }
}