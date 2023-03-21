class Number : Term
{
    double _value;
    public Number(double Value)
    {
        _value = Value;
        _type = "Number";
    }
    public override void Display()
    {
        Console.Write(_value);
    }
}