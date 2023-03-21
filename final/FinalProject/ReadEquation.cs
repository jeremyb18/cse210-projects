class ReadEquation
{
    string EQstring = "";
    List<Term> Elements = new List<Term>{};
    List<string> Operators = new List<string>{"+","-","*","/","^","$","@"};
    string Varibles = "abcdefghijklmnopqrstuvwxyz";
    public ReadEquation(string Input)
    {
        EQstring = Input.Replace(" ", "").ToLower();
        EQstring = EQstring.Replace("**", "^");
        EQstring = EQstring.Replace("sin", "$");
        EQstring = EQstring.Replace("cos", "@");
    }
    public List<Term> Separate()
    {
        
        while(EQstring.Length > 0)
        {
            if(!IsNumber())
            {
                if(!IsOperator())
                {
                    if(!IsVarible())
                    {
                        if(!IsParentheses())
                        {
                            EQstring = StringMethod.RemoveFirst(EQstring);
                        }
                    }
                }
            }
        }
        return Elements;
    }
    private bool IsOperator()
    {
        string C = EQstring[0].ToString();
        foreach(string Operator in Operators)
        {
            if(Operator == C)
            {
                EQstring = EQstring.Remove(0,1);
                Elements.Add(new Operator(C));
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
                    EQstring = "";
                    break;
                }
            }
            Elements.Add(new Number(int.Parse(Number)));
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
                    if(EQstring.Length > 1)
                    {
                        EQstring = StringMethod.RemoveFirst(EQstring);
                        C = EQstring[0].ToString();
                        IsCharVarible = true;
                    }
                    else
                    {
                        EQstring = "";
                        Elements.Add(new Varible(NameVarible));
                        return true;
                    }
                    
                }
            }
        }while(IsCharVarible);
        if(NameVarible.Length > 0)
        {
            Elements.Add(new Varible(NameVarible));
            return true;

        }
        return false;
    }
    private bool IsParentheses()
    {
        string C = EQstring[0].ToString();
        
        string subEquation = "";
        if(C == "(")
        {
            int CountPerentheses = 1;
            EQstring = StringMethod.RemoveFirst(EQstring);
            C = StringMethod.GetFirst(EQstring);
            while(CountPerentheses != 0 )
            {
                if(C == "")
                {
                    break;
                }
                if(C == "(")
                {
                    CountPerentheses++;
                } 
                else if(C == ")")
                {
                    CountPerentheses--;
                }
                if(CountPerentheses != 0)
                {
                    subEquation += C;
                }
                EQstring = StringMethod.RemoveFirst(EQstring);
                C = StringMethod.GetFirst(EQstring);
                
            }
            Elements.Add(new Equation(subEquation));
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public void Display()
    {
        foreach(Term E in Elements)
        {
            E.Display();
            Console.Write(",");
        }
    }
}