class WordHidder 
{
    List<int> _NonHiddenWords = new List<int>{};
    scripture _ObjectToManipulate;
    bool AllHidden = false;
    public WordHidder(scripture scrpt){

        for(int i = 0; i < scrpt.LengthOfScripture(); i++)
        {
            _NonHiddenWords.Add(i);
        }
        _ObjectToManipulate = scrpt;
    }
    public void Hide(int AmountToHide)
    {
        for(int i = 0; i < AmountToHide;i++)
        {
            if(_NonHiddenWords.Count == 0)
            {
                AllHidden = true;
                Console.WriteLine("Everything is Hidden");
                break;
            }
            Random randomGenerator = new Random();
            int R = randomGenerator.Next(0, _NonHiddenWords.Count);
            _ObjectToManipulate.HideWord(_NonHiddenWords[R]);
            _NonHiddenWords.RemoveAt(R);
        }
    }
    public bool IsAllHidden(){
        return AllHidden;
    }
}