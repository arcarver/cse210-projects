using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager(5, [new EternalGoal("goal1", "", 5)]);
        goalManager.SaveGoals();
        goalManager.LoadGoals();
        goalManager.ListGoalNames("Eat Protein");
    }
}