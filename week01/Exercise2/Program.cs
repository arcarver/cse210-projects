using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else (grade < 90 && grade >= 80)
        {
            Console.WriteLine("Your grade is an B");
        }
        else (grade < 80 && grade >= 70)
        {
            Console.WriteLine("Your grade is an C");
        }
        else (grade < 70 && grade >= 60)
        {
            Console.WriteLine("Your grade is an D");
        }
        else (grade < 60)
        {
            Console.WriteLine("Your grade is an F");
        }
    }
}