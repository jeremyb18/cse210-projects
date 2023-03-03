class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        prepGoal();
    }
    public  override void DoGoal()
    {
        AddPoints();
        _achieved = true;
    }
    public override string GetStringRepresentation()
    {
        saveTxt = $"SimpleGoal:Goal,{_name},{_description},{_points},{_achieved}";
        return saveTxt;
    }
}