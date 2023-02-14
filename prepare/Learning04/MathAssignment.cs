class MathAssignment : Assignment
{
    private string _TextBookSection;
    private string _Problems;
    public MathAssignment(string name,string topic,string section,string problems) : base(name,topic)
    {
        _Problems = problems;
        _TextBookSection = section;
    }
    public void GetHomeworkList()
    {
        GetSummary();
        Console.WriteLine($"Sectrion {_TextBookSection} Problems {_Problems}");
    }
}