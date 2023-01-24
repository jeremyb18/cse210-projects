class Entry
{
    public string _Date = DateTime.Now.ToString("dd/MM/yyyy");
    public string _Promt;
    public string _UserText;
    public Entry(bool FastLoad = false)
    {
        if(FastLoad == false)
        {
        _Promt = RandomPromtGenerator();
        Console.WriteLine(_Promt);
        Console.Write(" > ");
        _UserText = Console.ReadLine();
        }
    }
    public string RandomPromtGenerator()
    {
        List<string> Promts = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(0, Promts.Count-1);
        return Promts[RandomNumber];
    }
    public void Display()
    {
        Console.WriteLine($"{this._Date} - {this._Promt} \n > {this._UserText}");
    }
}