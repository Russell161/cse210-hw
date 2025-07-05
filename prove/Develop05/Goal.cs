public abstract class Goal
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveData();

    public static Goal LoadData(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        switch (type)
        {
            case "Simple":
                return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
            case "Eternal":
                return new EternalGoal(parts[1], int.Parse(parts[2]));
            case "Checklist":
                return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
            default:
                throw new Exception("Invalid goal type");
        }
    }
}
