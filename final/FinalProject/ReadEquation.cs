class ReadEquation
{
    string EQstring = "";
    List<Term> Elements = new List<Term>{};
    List<string> Operators = new List<string>{"+","-","*","/","^","$","@"};
    public bool IsValid = true;
    string Varibles = "abcdefghijklmnopqrstuvwxyz";
    public ReadEquation(string Input)
    {
        EQstring = Input.Replace(" ", "").ToLower();
        EQstring = EQstring.Replace("**", "^");
        EQstring = EQstring.Replace("sin", "$");
        EQstring = EQstring.Replace("cos", "@");
        Separate();
        IsEquationValid();
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
                            IsValid = false;
                            EQstring = StringMethod.RemoveFirst(EQstring);
                        }
                    }
                }
            }
        }
        return Elements;
    }
    public bool IsEquationValid()
    {
        if(Elements.Count != 0)
        {
            if(!Double.IsNaN(Elements[0].Value()) & !Double.IsNaN(Elements[Elements.Count-1].Value()))
            {
                for(int i = 1; i < Elements.Count-1; i++)
                {
                    string Type = Elements[i]._type;
                    if(Double.IsNaN(Elements[i].Value()) & Double.IsNaN(Elements[i-1].Value()))
                    {
                        if(Type != "$" & Type != "@")
                        {
                            IsValid = false;
                        }
                    }
                    
                }
                foreach(Term T in Elements)
                {
                    if(T._type == "Equation" & !T.IsValid)
                    {
                        IsValid = false;
                    }
                }
            }else{IsValid = false;}
            
        }else{IsValid = false;}
        return IsValid;
    }
    public Term OderOfOperations()
    {
        CombineTrig();
        CombineOperations("^");
        CombineOperations("*","/");
        CombineOperations("+","-");
        return Elements[0];
    }
    private void CombineTrig()
    {
        for(int i = 0; i < Elements.Count-1; i++)
        {
            string Type = Elements[i]._type;
            double nextValue = Elements[i+1].Value();
            if(Type == "@" || Type == "$")
            {
                if(Double.IsNaN(nextValue))
                {
                    Console.WriteLine($"Error in Trig: {Type} : {nextValue}");
                    Term.IsRunnable = false;
                    break;
                }
            }
            List<Term> data = new List<Term>{};
            switch(Type)
            {
                case("@"):
                data.Add(Elements[i+1]);
                Elements[i].Assign(data);
                Elements.RemoveAt(i+1);
                    break;
                case("$"):
                data.Add(Elements[i+1]);
                Elements[i].Assign(data);
                Elements.RemoveAt(i+1);
                    break;
            }
        }
    }
    void CombineOperations(string O1, string O2)
    {
        for(int i = 1; i < Elements.Count-1; i++)
        {
            string Type = Elements[i]._type;
            
            if(Type == O1 || Type == O2)
            {
                double pastValue = Elements[i-1].Value();
                double nextValue = Elements[i+1].Value();
                if(Double.IsNaN(nextValue) || Double.IsNaN(pastValue))
                {
                    Console.WriteLine($"Error with {O1} and {O2}: {Type} : {pastValue} : {nextValue}");
                    Term.IsRunnable = false;
                    break;
                }
                List<Term> data = new List<Term>{};
                data.Add(Elements[i-1]);
                data.Add(Elements[i+1]);
                Elements[i].Assign(data);
                Elements.RemoveAt(i+1);
                Elements.RemoveAt(i-1);
                i--;
            }
        }
    }
    void CombineOperations(string O)
    {
        for(int i = 1; i < Elements.Count-1; i++)
        {
            string Type = Elements[i]._type;
            if(Type == O)
            {
                double pastValue = Elements[i-1].Value();
                double nextValue = Elements[i+1].Value();
                if(Double.IsNaN(nextValue) || Double.IsNaN(pastValue))
                {
                    Console.WriteLine($"Error with {O}: {Type} : {pastValue} : {nextValue}");
                    Term.IsRunnable = false;
                    break;
                }
                List<Term> data = new List<Term>{};
                data.Add(Elements[i-1]);
                data.Add(Elements[i+1]);
                Elements[i].Assign(data);
                Elements.RemoveAt(i+1);
                Elements.RemoveAt(i-1);
                i--;
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
                Elements.Add(new Operator(C));
                return true;
            }
        }
        return false;
    }
    private bool IsNumber()
    {
        double n;
        string C = EQstring[0].ToString();
        string stringNumber = "0";
        if(double.TryParse(C, out n))
        {
            int Amount = Elements.Count;
            if(Amount > 0)
            {
                if(Elements[Amount-1]._type == "Varible" || Elements[Amount-1]._type == "Equation")
                {
                    Elements.Add(new Operator("*"));
                }
            }
            while(double.TryParse(stringNumber + C, out n))
            {
                stringNumber += C;
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
            Elements.Add(new Number(double.Parse(stringNumber)));
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
                        int Amount = Elements.Count;
                        if(Amount > 0)
                        {
                            if(Elements[Amount-1]._type == "Number" || Elements[Amount-1]._type == "Equation")
                            {
                                Elements.Add(new Operator("*"));
                            }
                        }
                        Elements.Add(new Varible(NameVarible));
                        return true;
                    }
                    
                }
            }
        }while(IsCharVarible);
        if(NameVarible.Length > 0)
        {
            int Amount = Elements.Count;
            if(Amount > 0)
            {
                if(Elements[Amount-1]._type == "Number" || Elements[Amount-1]._type == "Equation")
                {
                    Elements.Add(new Operator("*"));
                }
            }
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
            int Amount = Elements.Count;
            if(Amount > 0)
            {
                if(Elements[Amount-1]._type == "Varible" || Elements[Amount-1]._type == "Number" || Elements[Amount-1]._type == "Equation")
                {
                    Elements.Add(new Operator("*"));
                }
            }
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