class Number : Term
{
    public Number(double Value)
    {
        _value = Value;
        _type = "Number";
    }
    public override void Display()
    {
        Console.Write(_value);
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