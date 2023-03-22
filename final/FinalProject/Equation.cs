class Equation : Term
{
    List<Term> _terms = new List<Term>();
    Term _term;
    public static bool IsRunable = true;
    ReadEquation _EQ;
    
    public Equation(string EQstring)
    {
        _EQ = new ReadEquation(EQstring);
        _terms = _EQ.Separate();
        _term = _EQ.OderOfOperations();
        _type = "Equation";
        _value = 0;
    }
    public override void Assign(List<Term> data)
    {
        throw new NotImplementedException();
    }
    public override double Value()
    {
        return _term.Value();
    }
    
    public override void Display()
    {
        Console.Write("(");
        _EQ.Display();
        Console.Write(")");
    }
}