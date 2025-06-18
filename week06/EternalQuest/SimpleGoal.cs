public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }
    public override void RecordProgress()
    {
        isComplete = true;
        Console.WriteLine($"Completed! You earned {points} points!");
    }
    public override string GetProgress()
    {
        return isComplete ? "[X]" : "[ ]";
    }
    public override string GetGoalType()
    {
        return "Simple Goal";
    }
}