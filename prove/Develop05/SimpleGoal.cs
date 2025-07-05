public class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int points, bool completed = false) : base(name, points)
    {
        this.completed = completed;
    }

    public override bool IsComplete() => completed;

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => completed ? "[X] " + Name : "[ ] " + Name;
    public override string SaveData() => $"Simple|{Name}|{Points}|{completed}";
}
