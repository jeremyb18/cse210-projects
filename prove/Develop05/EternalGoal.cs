class EternalGoal : Goal
{
    int _timesCompleted = 0;
    public EternalGoal()
    {
        prepGoal();
    }
    public EternalGoal(string[] info)
    {
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _timesCompleted = int.Parse(info[3]);
    }
    public  override void RecordEvent()
    {
        _timesCompleted += 1;
        AddPoints();
    }
    public  override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($"---- Currently completed: {_timesCompleted} times");
    }
    public override string GetStringRepresentation()
    {
        saveTxt = $"EternalGoal:{_name},{_description},{_points},{_timesCompleted}";
        return saveTxt;
    }
}