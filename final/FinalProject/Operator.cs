
class Operator : Term
{
    List<Term> _Inputs = new List<Term>{};
     public Operator(string Type)
     {
        _type = Type;
     }
     public override void Assign(List<Term> data)
    {
        _Inputs = data;
        Calculate();
    }
     public double Calculate()
     {
        switch(_type)
        {
            case "+":
                _value = _Inputs[0].Value() + _Inputs[1].Value();
                break;
            case "-":
                _value = _Inputs[0].Value() - _Inputs[1].Value();
                break;
            case "*":
                _value = _Inputs[0].Value() * _Inputs[1].Value();
                break;
            case "/":
                _value = _Inputs[0].Value() / _Inputs[1].Value();
                break;
            case "^":
                _value = Math.Pow(_Inputs[0].Value() , _Inputs[1].Value()) ;
                break;
            case "$":
                _value = Math.Sin(_Inputs[0].Value());
                break;
            case "@":
                _value = Math.Cos(_Inputs[0].Value());
                break;
        }
        return _value;
     }
     public override void Display()
    {
        if(_type == "@")
        {
            Console.Write("Cos");
        } 
        else if(_type == "$")
        {
            Console.Write("Sin");
        }
        else
        {
            Console.Write(_type);
        }

    }
     public override double Value()
    {
        if(!double.IsNaN(_value))
        {
            Calculate();
        }
        return _value;
    }
}