
public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int targetTimes;
    private int bonusPoints;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        timesCompleted = 0;
        targetTimes = target;
        bonusPoints = bonus;
    }
    
        public int GetBonus() => bonusPoints;
        public int GetTarget() => targetTimes;
        public int GetTimesCompleted() => timesCompleted;
    public override void RecordProgress()
    {
        timesCompleted++;

        if (timesCompleted >= targetTimes)
        {
            isComplete = true;
            Console.WriteLine($"Completed! You earned {points + bonusPoints} points (including bonus)!");
        }
        else
        {
            Console.WriteLine($"Progress recorded! You earned {points} points!");
        }
    }
    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{targetTimes} times";
    }
    public override string GetGoalType()
    {
        return "Checklist Goal";
    }
}
