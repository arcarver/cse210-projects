using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        Entry entry = new Entry();
        // DateTime currentDate = DateTime.Today;
        entry._date = DateTime.Today.ToString();
        PromptGenerator promptGenerator = new PromptGenerator();
        entry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Here is today's writing prompt: {entry._promptText}");
        Console.WriteLine("Journal Entry: ");
        entry._entryText = Console.ReadLine();

        journal.AddEntry(entry);
        journal.DisplayAll();
    }
}