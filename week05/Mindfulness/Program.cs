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
                BreathingActivity breathingActivity1 = new BreathingActivity();
                breathingActivity1.Run();
            }
            else if (choice == "2")
            //  Reflecting Activity
            {
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                reflectingActivity1.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity1 = new ListingActivity();
                listingActivity1.Run();
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