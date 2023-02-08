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
    public void HideWord(int i)
    {
        _Words[i].setHidden();
    }
    public void Display()
    {
        Console.Write(_Title);
        foreach(word w in _Words)
        {
            if(w.isNewVerse())
            {
                Console.WriteLine(" ");
            }
            Console.Write(" ");
            w.Display();
        }
    }
    public int LengthOfScripture()
    {
        return _Words.Count;
    }
}