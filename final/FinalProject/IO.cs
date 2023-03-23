static class IO 
{
    static public int ReadInt(string txt)
    {
        int n;
        bool isNumeric = true;
        do{
            Console.Write(txt);
            string input = Console.ReadLine();
            isNumeric = int.TryParse(input, out n);
        }while(!isNumeric);
        return n;
    }
    static public string Read(string txt)
    {
        Console.Write(txt);
        string input = Console.ReadLine();
        return input;
    }
    static public List<Term> ReadEquation(string txt)
    {
        int n;
        bool IsDoable = true;
        do{
            Console.Write(txt);
            string input = Console.ReadLine();
            IsDoable = int.TryParse(input, out n);
        }while(!IsDoable);
        return new List<Term>{}; 
    }
}