
class Operator : Term
{
    double _before;
    double _after;
    double _Output;
     public Operator(string Type)
     {
        _type = Type;
     }
     public double Calculate(double Before, double After)
     {
        _before = Before;
        _after = After;
        switch(_type)
        {
            case "+":
                _Output = _before + _after;
                break;
            case "-":
                _Output = _before - _after;
                break;
            case "*":
                _Output = _before * _after;
                break;
            case "/":
                _Output = _before / _after;
                break;
            case "^":
                _Output = Math.Pow(_before,_after) ;
                break;
            case "$":
                _Output = Math.Sin(_after);
                break;
            case "@":
                _Output = Math.Cos(_after);
                break;
        }
        return _Output;
     }
     public override void Display()
    {
        Console.Write(_type);
    }


}