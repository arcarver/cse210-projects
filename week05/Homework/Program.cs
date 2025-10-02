using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment name1 = new Assignment("Suzie", "science");

        Console.WriteLine(name1.GetSummary());
    }
}
