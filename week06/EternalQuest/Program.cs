using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("A simple goal tracking program");
        Console.WriteLine("----------------------------");
        
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. View All Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Goal Progress");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    manager.ShowGoals();
                    break;
                case "2":
                    manager.CreateGoal();
                    break;
                case "3":
                    manager.RecordProgress();
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    manager.SaveGoals();
                    break;
                case "6":
                    manager.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }      
    }
}