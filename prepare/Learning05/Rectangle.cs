class Rectangle : Shape
{
    double _length;
    double _width;
    public Rectangle(string color, double Length, double Width) : base(color)
    {
        _length = Length;
        _width = Width;
    }
    
    public override double getArea()
    {
        return _length * _width;
    }
}