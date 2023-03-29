
class Operator : Term
{
    Term _before;
    Term _after;

     public Operator(string Type)
     {
        _type = Type;
     }
     public override void Assign(List<Term> data)
    {
        if(data.Count == 1)
        {
            _after = data[0];
            Calculate(0,_after.Value());
        }
        else if(data.Count == 2)
        {
            _before = data[0];
            _after = data[1];
            Calculate(_before.Value(),_after.Value());
        }
    }
     public void Calculate(double Before,double After)
     {
        switch(_type)
        {
            case "+":
                _value = Before + After;
                break;
            case "-":
                _value = Before - After;
                break;
            case "*":
                _value = Before * After;
                break;
            case "/":
                _value = Before / After;
                break;
            case "^":
                _value = Math.Pow(Before , After) ;
                break;
            case "$":
                _value = Math.Sin(After);
                break;
            case "@":
                _value = Math.Cos(After);
                break;
        }
     }
     public double Calculate()
     {
        switch(_type)
        {
            case "+":
                _value = _before.Value() + _after.Value();
                break;
            case "-":
                _value = _before.Value() - _after.Value();
                break;
            case "*":
                _value = _before.Value() * _after.Value();
                break;
            case "/":
                _value = _before.Value() / _after.Value();
                break;
            case "^":
                _value = Math.Pow(_before.Value() , _after.Value()) ;
                break;
            case "$":
                _value = Math.Sin(_after.Value());
                break;
            case "@":
                _value = Math.Cos(_after.Value());
                break;
        }
        return _value;
     }
     public override void Display()
    {
        Console.Write(_type);
    }
     public override double Value()
    {
        return _value;
    }
}