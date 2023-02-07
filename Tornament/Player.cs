class Player
{
    private string _name;
    private int _JerseyNumber;

    public Player(string name, int number)
    {
        _name = name;
        _JerseyNumber = number;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} {_JerseyNumber}");
    }
}