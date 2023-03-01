class Circle : Shape
{
    double _radius;
    public Circle(string color, double Radius) : base(color)
    {
        _radius = Radius;
    }
    
    public override double getArea()
    {
        return _radius * _radius * double.Pi;
    }
}