class Square : Shape
{
    double _side;
    public Square(string color, double Side) : base(color)
    {
        _side = Side;
    }
    public override double getArea()
    {
        return _side * _side;
    }
}