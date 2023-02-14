class WrittingAssignment : Assignment
{
    private string _Title;
    public WrittingAssignment(string name,string topic, string title) : base(name,topic)
    {
        _Title = title;
    }
    public void GetWrittingInformation()
    {
        GetSummary();
        Console.WriteLine($"{_Title}");
    }
}