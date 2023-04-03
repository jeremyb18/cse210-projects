class Varible : Term
{
    string _name;
    static List<string> _names = new List<string>{"x","y","pi","e"};
    static List<double> _values = new List<double>{0,0,Math.PI, Math.Exp(1)};
    int _idx = 0;
    public Varible(string Name)
    {
        _name = Name;
        _type = "Varible";
        bool IsDefined = false;
        for(int i = 0; i < _names.Count;i++)
        {
            if(_names[i] == Name)
            {
                _idx = i;
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
        Equation EQ = IO.ReadEquation($"Set {_name} = ");
        _value = EQ.Value();
        _idx = _values.Count;
        _names.Add(_name);
        _values.Add(_value);
    }
    public override void Display()
    {
        Console.Write(_name);
    }
    public override double Value()
    {
        _value = _values[_idx];
        return _value;
    }
    public string GetName()
    {
        return _name;
    }
    public override void Assign(List<Term> data)
    {
        _value = data[0].Value();
    }
    public static void SetX(double Value)
    {
        _values[0] = Value;
        
    }
    public static void DisplayVaribles()
    {
         for(int i = 4; i < _values.Count ; i++)
        {
            Console.WriteLine($"{i-3}. {_names[i]} = {_values[i]}");
        }
        Console.WriteLine($"{_values.Count-3}. Back");
    }
    public static void UpdateVarible(int _idx)
    {
        if(_idx < _values.Count & _idx > 0)
        {
            Equation EQ = IO.ReadEquation($"Set {_names[_idx]} = ");
            _values[_idx] = EQ.Value();
        }
        else if(_idx > _values.Count)
        {
            Menu.Varibles();
        }
        
    }
}