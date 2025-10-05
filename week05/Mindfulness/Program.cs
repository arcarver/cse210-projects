using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to my mindfullness Program");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("    1. Start Breathing Activity");
        Console.WriteLine("    2. Start Reflecting Activity");
        Console.WriteLine("    3. Start Listening Activity");
        Console.WriteLine("    4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        bool finish = false;
        while (finish != true)
        {
            if (choice == "1")
            {

            }
            else if (choice == "2") { }
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