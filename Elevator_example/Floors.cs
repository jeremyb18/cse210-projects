class Floor
{
    bool _isVIP = false;
    int _Number = 0;
    static int pNumber = 0;
    public Floor()
    {
        _Number = pNumber;
        pNumber++;
    }
    public Floor(bool IsVIP)
    {
        _Number = pNumber;
        pNumber++;
        _isVIP = IsVIP;
    }
    public void DisplayFloor(List<Elevator> Elevators)
    {
        Console.Write("\n");
        foreach( Elevator E in Elevators)
        {
            string inSide = " ";
            
            if(E._FloorNumber == _Number)
            {
                if(E._HasPassenger)
                {
                    inSide = "x";
                }
                if(E._IsDoorsOpen == false)
                {
                    inSide = "#";
                }
                Console.Write($"|[{inSide}]|");
            }
            else
            {
                Console.Write("|   |");
            }
            
        }

    }
}