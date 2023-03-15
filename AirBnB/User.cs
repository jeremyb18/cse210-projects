class User
{
    string _UserName = "";
    string _Address = "";
    int _UserID = 11223;
    static int PreviousUserID = 0;
    public Closet MyCloset = new Closet();
    //List<Clothing> MyCLothing = new List<Clothing>{};
    //List<Clothing> RentedClothing = new List<Clothing>{};

    public User()
    {
        PreviousUserID += 1;
        _UserID = PreviousUserID;
        Console.WriteLine("What is the user name?");
        _UserName = Console.ReadLine();
        Console.WriteLine("What is your address?");
        _Address = Console.ReadLine();
    }
    public RentClothing(Clothing ClothingToRent)
    {
        RentedClothing.Add(ClothingToRent);
    }
    public DisplayCloset()
    {
        MyCloset.DisplayItems();
    }
    public void DisplayAvaibleCloset()
    {
        MyCloset.DisplayAvaibleItems();
    }
    public string DisplayUserInfo()
    {
        Console.WriteLine($"User Name:{_UserName}");
    }
    public AddClothing()
    {

      Clothing newClothing = new Clothing(_Address);
      MyCLothing.AddItem(newClothing);
      
    }
    public string GetUserName()
    {
        return _UserName;
    }
    public string GetUserID()
    {
        return _UserID;
    }




}