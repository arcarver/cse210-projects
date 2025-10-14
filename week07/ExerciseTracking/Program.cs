using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running run1 = new Running("Nov 2, 2025", 60, 15);
        Swimming swim1 = new Swimming("May 7, 2025", 15, 20);
        Cycling cycle1 = new Cycling("June 4, 1977", 45, 3);
        ExerciseManager exerciseManager = new ExerciseManager([
            run1,
            swim1,
            cycle1
        ]);
        exerciseManager.ListExerciseDetails();
    }
}