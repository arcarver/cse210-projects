using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        // GoalManager goalManagerInstance = new GoalManager(5, []);
        // GoalManager goalManagerInstance = new GoalManager(5, [new EternalGoal("goal1", "lots of detail", "5")]);
        GoalManager goalManagerInstance = new GoalManager(0, []);
        goalManagerInstance.Start();
    }
}