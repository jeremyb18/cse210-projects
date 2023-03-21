class Varible : Term
{
    double _value;
    string _name;
    
    public Varible(string Name)
    {
        _name = Name;
        _type = "Varible";
    }
   // public override void Calculate()
   // {
      //  throw new NotImplementedException();
   // }
    public override void SetVarible()
    {
        _value = IO.ReadInt($"Set {_name} = ");
    }
    public override void Display()
    {
        Console.Write(_name);
    }
}