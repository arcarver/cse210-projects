using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running run1 = new Running("Nov 2, 2025", 60, 15);
        Console.WriteLine(run1.GetSummary());
        Swimming swim1 = new Swimming("May 7, 2025", 15, 20);
        Console.WriteLine(swim1.GetSummary());
        Cycling cycle1 = new Cycling("June 4, 1977", 45, 3);              
        Console.WriteLine(cycle1.GetSummary());
    }
}