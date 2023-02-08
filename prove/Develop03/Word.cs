class word
{
    private bool _Hidden = false;
    private string _letters = "";
    public word(string w)
    {
        _letters = w;
    }
    public void Display()
    {
        if(_Hidden)
        {
           int L = _letters.Length;
           for( int i = 0; i < L; i++)
           {
            Console.Write("_");
           }
        }
        else
        {
            Console.Write(_letters);
        }
    }
    public void setHidden()
    {
        _Hidden = true;
    }
    public bool isNewVerse()
    {
        return _letters.All(char.IsDigit);
    }

}