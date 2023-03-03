class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        prepGoal();
    }
    public SimpleGoal(string[] info)
    {
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _achieved = bool.Parse(info[3]);
    }
    public  override void RecordEvent()
    {
        AddPoints();
        _achieved = true;
    }
    public override string GetStringRepresentation()
    {
        saveTxt = $"SimpleGoal:{_name},{_description},{_points},{_achieved}";
        return saveTxt;
    }
}