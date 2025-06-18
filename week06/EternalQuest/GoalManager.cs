using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;
    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }
    public void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetProgress()} {goal.GetName()} - {goal.GetDescription()}");
            Console.WriteLine($"   Type: {goal.GetGoalType()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal (one-time)");
        Console.WriteLine("2. Eternal Goal (repeating)");
        Console.WriteLine("3. Checklist Goal (multiple times)");
        Console.Write("Select goal type: ");
        string typeChoice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completing: ");
        int points = int.Parse(Console.ReadLine());
        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times to complete for bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
        Console.WriteLine("New goal created successfully!");
    }
    public void RecordProgress()
    {
        ShowGoals();
        if (goals.Count == 0) return;
        Console.Write("Select goal to record progress: ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            Goal selectedGoal = goals[choice];
            selectedGoal.RecordProgress();
            
            // Add points to total
            totalPoints += selectedGoal.GetPoints();
            
            // If it's a checklist goal and just completed, add bonus
            if (selectedGoal is ChecklistGoal checklist && checklist.IsComplete())
            {
                totalPoints += checklist.GetBonus();
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    public void ShowScore()
    {
        Console.WriteLine($"\nYour Total Score: {totalPoints} points");
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save total points first
            writer.WriteLine(totalPoints);
            
            // Save each goal
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetGoalType();
                string line = $"{goalType}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}";
                
                if (goal is ChecklistGoal checklist)
                {
                    line += $"|{checklist.GetTarget()}|{checklist.GetBonus()}|{checklist.GetTimesCompleted()}";
                }
                
                writer.WriteLine(line);
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        goals.Clear();
        
        using (StreamReader reader = new StreamReader(filename))
        {
            // First line is total points
            totalPoints = int.Parse(reader.ReadLine());
            
            // Read each goal
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                switch (type)
                {
                    case "Simple Goal":
                        goals.Add(new SimpleGoal(name, desc, points));
                        break;
                    case "Eternal Goal":
                        goals.Add(new EternalGoal(name, desc, points));
                        break;
                    case "Checklist Goal":
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int completed = int.Parse(parts[6]);
                        var checklist = new ChecklistGoal(name, desc, points, target, bonus);
                        for (int i = 0; i < completed; i++) checklist.RecordProgress();
                        goals.Add(checklist);
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
