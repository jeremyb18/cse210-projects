class scripture
{
    private string _Title;
    private string _Text;
    private List<word> _Words =  new List<word>{};
    public scripture(string title, string text)
    {
        _Title = title;
        _Text = text;
        PopulateList();
    }
    public void PopulateList()
    {
        string[] wordArray = _Text.Split(" ");
        foreach(string w in wordArray)
        {
            _Words.Add(new word(w));
        }
    }
    public void Display()
    {
        foreach(word w in _Words)
        {
            w.Display();
        }
    }
}