
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }
    public override void RecordProgress()
    {
        Console.WriteLine($"Recorded! You earned {points} points!");
    }
    public override string GetProgress()
    {
        return "[ ]";
    }
    public override string GetGoalType()
    {
        return "Eternal Goal";
    }
}
