class Fraction
{
    private int _top = 1;
    private int _bottom = 1;
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int getTop()
    {
        return _top;
    }
    public void setTop(int set)
    {
        _top = set;
    }
    public int getBottom()
    {
        return _bottom;
    }
    public void setBottom(int set)
    {
        _bottom = set;
    }
    public string getFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double getDecimalValue()
    {
        return (double)_top/ (double)_bottom;
    }
}