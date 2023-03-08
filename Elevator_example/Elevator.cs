class Elevator 
{
    public bool _IsDoorsOpen = false;
    public int _FloorNumber = 0;
    public bool _HasPassenger = false;
    int _ToFloor = 0;
    public Elevator()
    {

    }
    public void CallElevator()
    {
        _ToFloor = IO.ReadInt("What floor do you what to go to?");
        do{
            Console.Clear();
            update();
            
            Thread.Sleep(1000);
        }while(_FloorNumber != _ToFloor);
    }
    public void update()
    {
            if(_FloorNumber > _ToFloor)
            {
                _FloorNumber--;
            }
            if(_FloorNumber < _ToFloor)
            {
                _FloorNumber++;
            }
    }
    public void OpenDoors()
    {

    }


}