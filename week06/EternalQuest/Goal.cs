using System;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected bool isComplete;
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        name = goalName;
        description = goalDescription;
        points = goalPoints;
        isComplete = false;
    }
    // These methods will be overridden by child classes
    public abstract void RecordProgress();
    public abstract string GetProgress();
    public abstract string GetGoalType();
    // Common methods for all goals
    public string GetName() => name;
    public string GetDescription() => description;
    public int GetPoints() => points;
    public bool IsComplete() => isComplete;
}
