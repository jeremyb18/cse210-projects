class Equation : Term
{
    List<Term> _terms = new List<Term>();
    Term _term;
    ReadEquation _EQreader;
    public Equation(string EQstring)
    {
        _EQreader = new ReadEquation(EQstring);
        _terms = _EQreader.Separate();
        IsValid = _EQreader.IsEquationValid();
        _term = _EQreader.OderOfOperations();
        _type = "Equation";
        _value = 0;
    }
    public override void Assign(List<Term> data)
    {
        throw new NotImplementedException();
    }
    public override double Value()
    {
        if(IsValid)
        {
            return _term.Value();
        }
        else
        {
            return double.NaN;
        }
        
    }
    public override void Display()
    {
        Console.Write("(");
        _EQreader.Display();
        Console.Write(")");
    }
    public void DisplayAnswer()
    {
        _EQreader.Display();
        Console.Write($" = {Value()}");
    }
    public bool Has(string Name)
    {
        List<Varible> Vars = _terms.OfType<Varible>().ToList();
        List<Equation> EQs = _terms.OfType<Equation>().ToList();
        foreach(Varible V in Vars)
        {
            if(V.GetName() == Name)
            {
                return true;
            }
        }
        foreach(Equation EQ in EQs)
        {
            if(EQ.Has(Name))
            {
                return true;
            }
        }
        return false;
    }
    public bool HasOnlyY()
    {
        if(Has("y") & _terms.Count == 1)
        {
            return true;
        }
        return false;
    }
}