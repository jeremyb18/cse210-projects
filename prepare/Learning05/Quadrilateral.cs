class Quadrilateral : Shape
{
    double _length;
    double _width;

    public Quadrilateral(string color, double Length, double Width) : base(color)
    {
        _length = Length;
        _width = Width;
    }
    public Quadrilateral(string color, double Side) : base(color)
    {
        _length = Side;
        _width = Side;
    }
    

    public override double getArea()
    {
        return _length * _width;
    }
}