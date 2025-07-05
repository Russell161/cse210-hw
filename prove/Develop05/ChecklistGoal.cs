public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, int points, int targetCount, int currentCount = 0, int bonus = 500)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = currentCount;
        this.bonus = bonus;
    }

    public override bool IsComplete() => currentCount >= targetCount;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            currentCount++;
            if (currentCount == targetCount)
                return Points + bonus;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} -- Completed {currentCount}/{targetCount} times";
    }

    public override string SaveData() => $"Checklist|{Name}|{Points}|{targetCount}|{currentCount}";
}
