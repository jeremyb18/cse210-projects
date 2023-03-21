static class StringMethod
{
    public static string RemoveFirst(string Letters)
    {
        if(Letters.Length > 1)
        {
            Letters = Letters.Remove(0,1);
            
        }
        else
        {
            Letters = "";
        }
        return Letters;
    }
    public static string GetFirst(string Letters)
    {
        if(Letters.Length > 0)
        {
            Letters = Letters[0].ToString();
        }
        else
        {
            Letters = "";
        }
        return Letters;
    }
}