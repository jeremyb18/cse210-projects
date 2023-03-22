class Varible : Term
{
    string _name;
    
    public Varible(string Name)
    {
        _name = Name;
        _type = "Varible";
        _value = 0;
    }
    public override void SetVarible()
    {
        _value = IO.ReadInt($"Set {_name} = ");
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