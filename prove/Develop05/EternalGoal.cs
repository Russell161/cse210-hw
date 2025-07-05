public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override bool IsComplete() => false;

    public override int RecordEvent() => Points;

    public override string GetStatus() => "[∞] " + Name;
    public override string SaveData() => $"Eternal|{Name}|{Points}";
}
