class Building
{
    List<Floor> Floors = new List<Floor>();
    int _NumberOfFloors;
    List<Elevator> _Elevators;
    public Building(int numberOfFloors,List<Elevator> Elevators)
    {
        _Elevators = Elevators;
        _NumberOfFloors = numberOfFloors;
        for(int i = 0; i < numberOfFloors; i++)
        {
            Floors.Add(new Floor());
        }
    }
    
    public void DisplayBuilding()
    {
        for(int i = _NumberOfFloors-1; i >= 0; i--)
        {
            Floors[i].DisplayFloor(_Elevators);
        }
    }
}