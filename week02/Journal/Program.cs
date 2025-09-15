using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();
        Entry entry = new Entry();
        entry._date = DateTime.Today.ToShortDateString();
        PromptGenerator promptGenerator = new PromptGenerator();
        entry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Here is today's writing prompt: {entry._promptText}");
        Console.WriteLine("Journal Entry: ");
        // entry._entryText = Console.ReadLine();
        entry._entryText = "my entry";

        myJournal.AddEntry(entry);
        myJournal.DisplayAll();

        Console.Write("Where would you like to save your file? ");
        // string fileName = Console.ReadLine();
        string fileName = "journal.csv";

        myJournal.SafeToFile(fileName);

        Console.WriteLine("Loading from file");
        Journal journalFromFile = new Journal();
        journalFromFile.LoadFromFile(fileName);
        journalFromFile.DisplayAll();
    }
}