using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        // GoalManager goalManagerInstance = new GoalManager(5, []);

        GoalManager goalManagerInstance = new GoalManager(5, [new EternalGoal("goal1", "lots of detail", "5")]);
        goalManagerInstance.Start();
        // goalManagerInstance.SaveGoals();
        // goalManagerInstance.LoadGoals();
        // goalManagerInstance.ListGoalDetails();
        // goalManagerInstance.ListGoalNames();
        // SimpleGoal newGoal = new SimpleGoal("name", "desc", "5");
        // yay record event works
        // newGoal.RecordEvent();

        // yay get string reprsentation works
        // string representation = newGoal.GetStringRepresntation();
        // Console.WriteLine(representation);

        // yay isComplete works
        // if (newGoal.IsComplete())
        // {
        //     Console.WriteLine("the world is blue!!!!");
        // }
        // or

        // if (SimpleGoal.IsComplete())
        // {
        //     Console.WriteLine("the world is blue!!!!");
        // }
    }
}