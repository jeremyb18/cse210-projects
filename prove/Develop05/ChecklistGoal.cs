class ChecklistGoal : Goal
{
    int _reps = 0;
    int _completedReps = 0;
    int _bonusPoints = 0;
    public ChecklistGoal()
    {
        prepGoal();
    }
    public  override void prepGoal()
    {
        base.prepGoal();
        _completedReps = IO.ReadInt("\nHow many times does this goal need to be achomplished for a bonus? ");
        _bonusPoints = IO.ReadInt("\nHow many points would this bonus give? ");
    }
    public  override void DoGoal()
    {
        _completedReps += 1;
        AddPoints();
        if(_completedReps >= _reps)
        {
            _achieved = true;
            AddPoints(_bonusPoints);
        }
    }
    public  override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($"---- Currently completed: [{_completedReps}/{_reps}]");
    }
    public override string GetStringRepresentation()
    {
        saveTxt = $"ChecklistGoal:Goal,{_name},{_description},{_points},{_bonusPoints},{_achieved},{_reps},{_completedReps}";
        return saveTxt;
    }
}