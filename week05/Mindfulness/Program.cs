using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to my mindfullness Program");

        // Activity activity1 = new Activity("home", "green", 30);
        // activity1.DisplayEndingMessage();

        bool finish = false;
        while (finish != true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflecting Activity");
            Console.WriteLine("    3. Start Listening Activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            // Breathing activity
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing";
                BreathingActivity breathingActivity1 = new BreathingActivity(name, description);

                breathingActivity1.Run();
            }
            else if (choice == "2")
            {
                // _prompts = prompts;
                // prompts.Add("Think of a time when you stood up for someone else");
                // prompts.Add("Think of a time when you did something really difficult.");
                // prompts.Add("Think of a time when you helped someone in need");
                // prompts.Add("Think of time when you did something truely selfless.");

                // questions = questions;
                // questions.Add("Why was this experience meaningful to you?");
                // questions.Add("Have you everdone anything like this before?");
                // questions.Add("How did you get started?");
                // questions.Add("How did you feel when it was complete?");
                // questions.Add("What mad this time different than other times when you were not as successful?");
                // questions.Add("What is your favorite thing about this experience?");
                // questions.Add("What could you learn from this experience that applies to other situations?");
                // questions.Add("What did you learn about yourself through this experience?");
                // questions.Add("How can you keep this experience in mind in the future?");
                string name = "Reflecting Activity";
                string description = "This activity will help you relect on times in your1 life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
                // ReflectingActivity reflectingActivity1 = new ReflectingActivity("prompts", "questions", name, description, duration);
            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using my mindfullness program. Have a nice day!");
                finish = true;
            }
            else
            {
                Console.WriteLine("Please select one of the options.");
            }
        }
    }
}