abstract class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected bool _achieved = false;
    protected int _points = 0;
    public static int Totalpoints = 0;
    protected string saveTxt = "";
    public virtual void prepGoal()
    {
        Console.Write("\nWhat would you like to name your goal? ");
        _name = Console.ReadLine();
        Console.Write("\nWrite a short descrition of your goal: ");
        _description = Console.ReadLine();
        _points = IO.ReadInt("\nHow many points would you like to assign to this goal? ");
    }
    abstract public void DoGoal();
    public virtual void DisplayGoal()
    {
        if(_achieved)
        {
            Console.Write("[X]");
        }
        else
        {
            Console.Write("[ ]"); 
        }
        Console.Write($"{_name} ({_description})");
    }
    abstract public string GetStringRepresentation();
    public void AddPoints(int N)
    {
        Console.WriteLine($"Congradulation! You got {N} bonus points");
        Totalpoints += N;
    }
    public void AddPoints()
    {
        Console.WriteLine($"Congradulation! You got {_points} points");
        Totalpoints += _points;
    }

}