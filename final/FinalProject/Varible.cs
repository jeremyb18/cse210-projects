class Varible : Term
{
    string _name;
    static List<string> _names = new List<string>{"x","pi","e"};
    static List<double> _values = new List<double>{0,Math.PI, Math.Exp(1)};
    int idx = 0;
    public Varible(string Name)
    {
        _name = Name;
        _type = "Varible";
        bool IsDefined = false;
        for(int i = 0; i < _names.Count;i++)
        {
            if(_names[i] == Name)
            {
                idx = i;
                _value = _values[i];
                IsDefined = true;
            }
        }
        if(!IsDefined)
        {  
            SetVarible();
        }
        
    }
    public void SetVarible()
    {
        _value = IO.ReadInt($"Set {_name} = ");
        idx = _values.Count;
        _names.Add(_name);
        _values.Add(_value);
    }
    public void SetName(string Name)
    {
        _name = Name;
    }
    public string GetName()
    {
        return _name;
    }
    public override void Display()
    {
        Console.Write(_name);
    }
    public override double Value()
    {
        return _value;
    }
    public override void Assign(List<Term> data)
    {
        _value = data[0].Value();
    }
}