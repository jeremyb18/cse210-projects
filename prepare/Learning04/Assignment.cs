class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"Name: {_studentName}\nTopic: {_topic}");
    }

}