using System;

class Program
{
    static void Main(string[] args)
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