class Equation : Term
{
    List<Term> _terms = new List<Term>();
    public static bool IsRunable = true;
    ReadEquation _EQ;
    public Equation(string EQstring)
    {
        _EQ = new ReadEquation(EQstring);
        _terms = _EQ.Separate();
        _type = "Equation";
    }
    
    public double Calculate()
    {
        for(int i = 0; i < _terms.Count; i++)
        {
            if(_terms[i]._type == "^")
            {
                //_terms[i].Calculate(_terms[i], _terms[i]);
            }
        }
        return 12.2;
    }
    public override void Display()
    {
        Console.Write("(");
        _EQ.Display();
        Console.Write(")");
    }
}