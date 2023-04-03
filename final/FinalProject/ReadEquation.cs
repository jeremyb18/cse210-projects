class ReadEquation
{
    string _EQstring = "";
    List<Term> _Elements = new List<Term>{};
    List<Term> _SimplifiedElements = new List<Term>{};
    List<string> _Operators = new List<string>{"+","-","*","/","^","$","@"};
    string _Varibles = "abcdefghijklmnopqrstuvwxyz";
    public bool IsValid = true;
    public ReadEquation(string Input)
    {
        _EQstring = Input.Replace(" ", "").ToLower();
        _EQstring = _EQstring.Replace("**", "^");
        _EQstring = _EQstring.Replace("sin", "$");
        _EQstring = _EQstring.Replace("cos", "@");
    }
    public List<Term> Separate()
    {
        
        while(_EQstring.Length > 0)
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
                            _EQstring = StringMethod.RemoveFirst(_EQstring);
                        }
                    }
                }
            }
        }
        return _Elements;
    }
    public bool IsEquationValid()
    {
        if(_Elements.Count != 0)
        {
            if(!Double.IsNaN(_Elements[0].Value()) & !Double.IsNaN(_Elements[_Elements.Count-1].Value()))
            {
                for(int i = 1; i < _Elements.Count-1; i++)
                {
                    string Type = _Elements[i]._type;
                    if(Double.IsNaN(_Elements[i].Value()) & Double.IsNaN(_Elements[i-1].Value()))
                    {
                        if(Type != "$" & Type != "@")
                        {
                            Console.WriteLine(Type);
                            IsValid = false;
                        }
                    }
                    
                }
                foreach(Term T in _Elements)
                {
                    if(T._type == "Equation" & !T.IsValid())
                    {
                        IsValid = false;
                    }
                }
            }
            else
            {
                if(_Elements[0]._type != "$" & _Elements[0]._type != "@" || Double.IsNaN(_Elements[_Elements.Count-1].Value()))
                {
                    
                    IsValid = false;
                }
            }
            
        }else{IsValid = false;}
        return IsValid;
    }
    public Term OderOfOperations()
    {
        _SimplifiedElements = new List<Term>(_Elements);
        CombineTrig();
        CombineOperations("^");
        CombineOperations("*","/");
        CombineOperations("+","-");
        return _SimplifiedElements[0];
    }
    private void CombineTrig()
    {
        for(int i = 0; i < _SimplifiedElements.Count-1; i++)
        {
            string Type = _SimplifiedElements[i]._type;
            double nextValue = _SimplifiedElements[i+1].Value();
            if(Type == "@" || Type == "$")
            {
                if(Double.IsNaN(nextValue))
                {
                    Console.WriteLine($"Error in Trig: {Type} : {nextValue}");
                    break;
                }
            }
            List<Term> data = new List<Term>{};
            switch(Type)
            {
                case("@"):
                data.Add(_SimplifiedElements[i+1]);
                _SimplifiedElements[i].Assign(data);
                _SimplifiedElements.RemoveAt(i+1);
                    break;
                case("$"):
                data.Add(_SimplifiedElements[i+1]);
                _SimplifiedElements[i].Assign(data);
                _SimplifiedElements.RemoveAt(i+1);
                    break;
            }
        }
    }
    void CombineOperations(string O1, string O2)
    {
        for(int i = 1; i < _SimplifiedElements.Count-1; i++)
        {
            string Type = _SimplifiedElements[i]._type;
            
            if(Type == O1 || Type == O2)
            {
                double pastValue = _SimplifiedElements[i-1].Value();
                double nextValue = _SimplifiedElements[i+1].Value();
                if(Double.IsNaN(nextValue) || Double.IsNaN(pastValue))
                {
                    Console.WriteLine($"Error with {O1} and {O2}: {Type} : {pastValue} : {nextValue}");
                    break;
                }
                List<Term> data = new List<Term>{};
                data.Add(_SimplifiedElements[i-1]);
                data.Add(_SimplifiedElements[i+1]);
                _SimplifiedElements[i].Assign(data);
                _SimplifiedElements.RemoveAt(i+1);
                _SimplifiedElements.RemoveAt(i-1);
                i--;
            }
        }
    }
    void CombineOperations(string O)
    {
        for(int i = 1; i < _SimplifiedElements.Count-1; i++)
        {
            string Type = _SimplifiedElements[i]._type;
            if(Type == O)
            {
                double pastValue = _SimplifiedElements[i-1].Value();
                double nextValue = _SimplifiedElements[i+1].Value();
                if(Double.IsNaN(nextValue) || Double.IsNaN(pastValue))
                {
                    Console.WriteLine($"Error with {O}: {Type} : {pastValue} : {nextValue}");
                    break;
                }
                List<Term> data = new List<Term>{};
                data.Add(_SimplifiedElements[i-1]);
                data.Add(_SimplifiedElements[i+1]);
                _SimplifiedElements[i].Assign(data);
                _SimplifiedElements.RemoveAt(i+1);
                _SimplifiedElements.RemoveAt(i-1);
                i--;
            }
        }
    }
    private bool IsOperator()
    {
        string C = _EQstring[0].ToString();
        foreach(string Operator in _Operators)
        {
            if(Operator == C)
            {
                _EQstring = _EQstring.Remove(0,1);
                _Elements.Add(new Operator(C));
                return true;
            }
        }
        return false;
    }
    private bool IsNumber()
    {
        double n;
        string C = _EQstring[0].ToString();
        string stringNumber = "0";
        if(double.TryParse(C, out n))
        {
            int Amount = _Elements.Count;
            if(Amount > 0)
            {
                if(_Elements[Amount-1]._type == "Varible" || _Elements[Amount-1]._type == "Equation")
                {
                    _Elements.Add(new Operator("*"));
                }
            }
            while(double.TryParse(stringNumber + C, out n))
            {
                stringNumber += C;
                if(_EQstring.Length > 1)
                {
                    _EQstring = _EQstring.Remove(0,1);
                    C = _EQstring[0].ToString();
                }
                else
                {
                    _EQstring = "";
                    break;
                }
            }
            _Elements.Add(new Number(double.Parse(stringNumber)));
            return true;
        }
        return false;
    }
    private bool IsVarible()
    {
        string C = _EQstring[0].ToString();
        string NameVarible = "";
        bool IsCharVarible;
        do
        {
            IsCharVarible = false;
            foreach(char Varible in _Varibles)
            {
                if(Varible.ToString() == C)
                {
                    NameVarible += C;
                    if(_EQstring.Length > 1)
                    {
                        _EQstring = StringMethod.RemoveFirst(_EQstring);
                        C = _EQstring[0].ToString();
                        IsCharVarible = true;
                    }
                    else
                    {
                        _EQstring = "";
                        int Amount = _Elements.Count;
                        if(Amount > 0)
                        {
                            if(_Elements[Amount-1]._type == "Number" || _Elements[Amount-1]._type == "Equation")
                            {
                                _Elements.Add(new Operator("*"));
                            }
                        }
                        _Elements.Add(new Varible(NameVarible));
                        return true;
                    }
                    
                }
            }
        }while(IsCharVarible);
        if(NameVarible.Length > 0)
        {
            int Amount = _Elements.Count;
            if(Amount > 0)
            {
                if(_Elements[Amount-1]._type == "Number" || _Elements[Amount-1]._type == "Equation")
                {
                    _Elements.Add(new Operator("*"));
                }
            }
            _Elements.Add(new Varible(NameVarible));
            return true;

        }
        return false;
    }
    private bool IsParentheses()
    {
        string C = _EQstring[0].ToString();
        
        string subEquation = "";
        if(C == "(")
        {
            int Amount = _Elements.Count;
            if(Amount > 0)
            {
                if(_Elements[Amount-1]._type == "Varible" || _Elements[Amount-1]._type == "Number" || _Elements[Amount-1]._type == "Equation")
                {
                    _Elements.Add(new Operator("*"));
                }
            }
            int CountPerentheses = 1;
            _EQstring = StringMethod.RemoveFirst(_EQstring);
            C = StringMethod.GetFirst(_EQstring);
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
                _EQstring = StringMethod.RemoveFirst(_EQstring);
                C = StringMethod.GetFirst(_EQstring);
                
            }
            _Elements.Add(new Equation(subEquation));
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public void Display()
    {
        foreach(Term E in _Elements)
        {
            E.Display();
            Console.Write("");

        }

    }
}