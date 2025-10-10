using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;
    public GoalManager(int score)
    {
        _score = score;
    }
    public void Start() { }
    // Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.

    public void DisplayPlayerInfo() { }
    // DisplayPlayerInfo - Displays the players current score.
    public void ListGoalNames() { }
    // ListGoalNames - Lists the names of each of the goals.
    public void ListGoalDetails() { }
    // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    public void CreateGoal() { }
    // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    public void RecordEvent() { }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void SaveGoals() { }
    // SaveGoals - Saves the list of goals to a file.
    public void LoadGoals() { }
    // LoadGoals - Loads the list of goals from a file.
    
}