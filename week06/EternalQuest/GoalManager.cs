using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime;
using System.Threading.Channels;

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
        Console.WriteLine("Welcome to the 'Eternal Quest Game!");
        bool finish = false;
        while (finish != true)
        {

            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
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
                CreateGoal();
            }
            else if (option == "2")
            {
                // ListGoalNames();
                ListGoalDetails();
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
                RecordEvent();
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
        // int goalNumber = 1;
        // foreach (Goal goalInstance in _goals)
        // {
        //     string name = goalInstance.GetNameString();
        //     Console.WriteLine($"{goalNumber}.  {name}");
        //     goalNumber++;
        // }
        for (int i = 0; i < _goals.Count; i++)
        {
            string name = _goals[i].GetNameString();
            Console.WriteLine($"{i+1}.  {name}");
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
                Console.WriteLine($"[X] {details}");
                
            }
            else
            {
                
                Console.WriteLine($"[ ] {details}");
            }
        }
    }
    public void CreateGoal()
    {
        // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
        Console.WriteLine();
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of Goal would you like to create");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short descriptions of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        
        Goal newGoal;
        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (choice == "2")
        {

            newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string targetS = Console.ReadLine();
            int target = int.Parse(targetS);
            int amountCompleted = 0;
            Console.Write($"What is the bonus for accomplishing your goal {target} times? ");
            string bonusS = Console.ReadLine();
            int bonus = int.Parse(bonusS);
            newGoal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Please select a valid option.");
        }
        
        
    }
    public void RecordEvent()
    {
        // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string selectionS = Console.ReadLine();
        int selection = int.Parse(selectionS);
        selection--;
        _goals[selection].RecordEvent();
        // award points 
        string pointsS = _goals[selection].GetPoints();
        int points = int.Parse(pointsS);

        _score += points;
       
       

        
        
    }
    
    public void SaveGoals()
    {
        // SaveGoals - Saves the list of goals to a file.
        Console.Write("What is the filename for the goal file? ");
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
        
        // LoadGoals - Loads the list of goals from a file.
        Console.WriteLine("What is the name of the file you would like to load? ");
        // string loadFileName = Console.ReadLine();
        string loadFileName = "a.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFileName);
        string score = lines[0];
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
                if (finished == "True")
                {
                    simpleGoalInstance.RecordEvent();
                }
                _goals.Add(simpleGoalInstance);
            }
            else if (goalType == "ChecklistGoal")
            {
                
                
                string timesDoneS = parts[4];
                int timesDone = int.Parse(timesDoneS);
                string timeToDoGoalS = parts[5];
                int timeToDoGoal = int.Parse(timeToDoGoalS);
                string bonusPointsS = parts[6];

                int bonusPoints = int.Parse(bonusPointsS);
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, pointsToEarn, timesDone, timeToDoGoal, bonusPoints);
                _goals.Add(checklistGoal);
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalName, goalDescription, pointsToEarn));
            }

        }



    }
}