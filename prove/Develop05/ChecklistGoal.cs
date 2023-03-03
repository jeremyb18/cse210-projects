class ChecklistGoal : Goal
{
    int _reps = 0;
    int _completedReps = 0;
    int _bonusPoints = 0;
    public ChecklistGoal()
    {
        prepGoal();
    }
    public ChecklistGoal(string[] info)
    {
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _bonusPoints = int.Parse(info[3]);
        _achieved = bool.Parse(info[4]);
        _reps = int.Parse(info[5]);
        _completedReps = int.Parse(info[6]);
    }
    public  override void prepGoal()
    {
        base.prepGoal();
        _reps = IO.ReadInt("\nHow many times does this goal need to be achomplished for a bonus? ");
        _bonusPoints = IO.ReadInt("\nHow many points would this bonus give? ");
    }
    public  override void RecordEvent()
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
        saveTxt = $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_achieved},{_reps},{_completedReps}";
        return saveTxt;
    }
}