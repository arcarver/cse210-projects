using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2007;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Human Resources";
        job2._company = "Apple";
        job2._startYear = 2016;
        job2._endYear = 2024;

        //     Console.WriteLine(job1._company);
        //     Console.WriteLine(job2._company);
        // }
        job1.Display();
        job2.Display();
        Resume resume1 = new Resume();
        resume1._name = "Susie Hobbs";
        

        resume1._jobs.Add(job1);


        
        resume1._jobs.Add(job2);

        Console.WriteLine(resume1._jobs[0]._jobTitle);
    }
}