class Equation
{
    string EQstring = "";
    List<string> Elements = new List<string>{};
    List<string> Operators = new List<string>{"+","-","*","(",")","^","=","$","@","e"};
    string Varibles = "abcdefghijklmnopqrstuvwxyz";
    public Equation(string Input)
    {
        Console.WriteLine(EQstring.Length);
        EQstring = Input.Replace(" ", "").ToLower();
        EQstring = EQstring.Replace("sin", "$");
        EQstring = EQstring.Replace("cos", "@");
        Console.WriteLine(EQstring);
        Separate();
        Console.WriteLine(EQstring);
        Display();
    }
    private void Separate()
    {
        
        while(EQstring.Length > 0)
        {
            if(!IsNumber())
            {
                if(!IsOperator())
                {
                    if(!IsVarible())
                    {
                        break;
                    }
                }
            }
        }
    }
    private bool IsOperator()
    {
        string C = EQstring[0].ToString();
        foreach(string Operator in Operators)
        {
            if(Operator == C)
            {
                EQstring = EQstring.Remove(0,1);
                Elements.Add(C);
                return true;
            }
        }
        return false;
    }
    private bool IsNumber()
    {
        int n;
        string C = EQstring[0].ToString();
        string Number = "";
        if(int.TryParse(C, out n))
        {
            while(int.TryParse(C, out n))
            {
                
                Number += n;
                if(EQstring.Length > 1)
                {
                    EQstring = EQstring.Remove(0,1);
                    C = EQstring[0].ToString();
                }
                else
                {
                    break;
                }
            }
            Elements.Add(Number);
            return true;
        }
        return false;
    }
    private bool IsVarible()
    {
        string C = EQstring[0].ToString();
        string NameVarible = "";
        bool IsCharVarible;
        do
        {
            IsCharVarible = false;
            foreach(char Varible in Varibles)
            {
                if(Varible.ToString() == C)
                {
                    NameVarible += C;
                    EQstring = EQstring.Remove(0,1);
                    C = EQstring[0].ToString();
                    IsCharVarible = true;
                    
                    if(EQstring.Length > 0)
                    {
                        Elements.Add(NameVarible);
                        return true;
                    }
                    
                }
            }
        }while(IsCharVarible);
        if(NameVarible.Length > 0)
        {
            Elements.Add(NameVarible);
            return true;

        }
        return false;
    }
    public void Display()
    {
        foreach(string E in Elements)
        {
            Console.Write($"|{E}|");
        }
    }
}