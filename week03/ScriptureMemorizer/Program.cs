using System;

class Program
{
    static void Main(string[] args)
    {
        string stop = "";
        // stop = "quit";
        // tests();

        Reference multiReference = new Reference("Proverbs ", 3, 5, 6);
        Scripture firstScripture = new Scripture(multiReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        clearConsole();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        while (stop != "quit")
        {
            // Console.WriteLine($"MultiReference {multiReference.GetDisplayText()}");
            // write the scripture
            Console.WriteLine($"{firstScripture.GetDisplayText()}");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            stop = Console.ReadLine();
            // if the number of words that are not hidden become 0 then the stop = quit
            if (firstScripture.IsCompletelyHidden() == true)
            {
                stop = "quit";
            }

            if (stop != "quit")
            {
                clearConsole();

                // block our words
                firstScripture.HideRandomWords(3);
            }
        }
    }

    static void clearConsole()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // IOException happens if debugger is running
            // Add blank line instead
            Console.WriteLine("");
        }
    }

    static void tests()
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Word happyWord = new Word("happy");
        Console.WriteLine($"Word: {happyWord.GetDisplayText()}");
        Console.WriteLine($"Word IsHidden: {happyWord.IsHidden()}");
        happyWord.Hide();
        Console.WriteLine($"Word IsHidden after Hide: {happyWord.IsHidden()}");
        happyWord.Show();
        Console.WriteLine($"Word IsHidden after Show: {happyWord.IsHidden()}");
        Reference firstReference = new Reference("1 Nephi", 1, 1);
        Console.WriteLine($"Reference {firstReference.GetDisplayText()}");
        Reference multiReference = new Reference("1 Nephi", 2, 3, 5);
        Console.WriteLine($"MultiReference {multiReference.GetDisplayText()}");
        Scripture firstScripture = new Scripture(firstReference, "I Nephi having");
        Console.WriteLine($"FirstScripture: {firstScripture.GetDisplayText()}");
        Console.WriteLine($"FirstScripture Hidden {firstScripture.IsCompletelyHidden()}");
        firstScripture.HideRandomWords(1);
        Console.WriteLine($"FirstScripture 1 hidden: {firstScripture.GetDisplayText()}");
        Console.WriteLine($"FirstScripture Hidden {firstScripture.IsCompletelyHidden()}");
        firstScripture.HideRandomWords(2);
        Console.WriteLine($"FirstScripture all hidden: {firstScripture.GetDisplayText()}");
        Console.WriteLine($"FirstScripture Hidden {firstScripture.IsCompletelyHidden()}");
    }
}