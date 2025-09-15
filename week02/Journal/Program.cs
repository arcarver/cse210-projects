using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();
        Boolean quitProgram = false;
        while (!quitProgram)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Add Entry");
            Console.WriteLine("2 - Show journal entries");
            Console.WriteLine("3 - Save to file");
            Console.WriteLine("4 - Load from file");
            Console.WriteLine("5 - Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Today.ToShortDateString();
                PromptGenerator promptGenerator = new PromptGenerator();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Here is today's writing prompt: {entry._promptText}");
                Console.WriteLine("Journal Entry: ");
                // entry._entryText = Console.ReadLine();
                entry._entryText = "my entry";

                myJournal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {

                Console.Write("Where would you like to save your file? ");
                // string fileName = Console.ReadLine();
                string fileName = "journal.json";

                myJournal.SafeToFile(fileName);

                
            }
            else if (choice == "4")
            {
                Console.WriteLine("Loading from file");
                
                Console.WriteLine("What file do you want to load? ");
                // string fileName = Console.ReadLine();
                string fileName = "journal.json";
                myJournal.LoadFromFile(fileName);
                
            }
            else
            {
                quitProgram = true;
            }
        }
    }
}