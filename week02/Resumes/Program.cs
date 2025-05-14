using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Tesla";
        job1._jobTittle = "Web developer";
        job1._startYear = 2023;
        job1._endYear = 2024;

        job1.Display();


        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTittle = "Software Engineer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        job2.Display();

        Resume resume = new Resume();
        resume._name = "Joseph";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }  
}