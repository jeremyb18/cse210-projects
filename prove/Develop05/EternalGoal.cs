class EternalGoal : Goal
{
    int _timesCompleted = 0;
    public EternalGoal()
    {
        prepGoal();
    }
    public  override void DoGoal()
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
        saveTxt = $"EternalGoal:Goal,{_name},{_description},{_points},{_timesCompleted}";
        return saveTxt;
    }
}