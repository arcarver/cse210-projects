using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment name1 = new Assignment("Suzie", "science");
        Console.WriteLine(name1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("George", "Math", "chapter 5", "2,4,6,8,15");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Sally", "Poetry", "Where the Sidewalk Ends");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}
