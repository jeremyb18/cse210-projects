abstract class Shape
{
    string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string getColor()
    {
        return _color;
    }
    public void setColor(string NewColor)
    {
        _color = NewColor;
    }
    public abstract double getArea();
}