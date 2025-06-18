using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        // Create activities
        activities.Add(new Running(new DateTime(2023, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2023, 11, 3), 30, 9.7));
        activities.Add(new Swimming(new DateTime(2023, 11, 3), 30, 20));

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}