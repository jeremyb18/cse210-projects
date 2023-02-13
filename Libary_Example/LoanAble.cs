 class LoanAble
 {
    private bool _IsCheckedIn = true;
    public void CheckOut()
    {
        _IsCheckedIn = false;
    }
    public void CheckIn(){
        _IsCheckedIn = true;
    }
    public void Display()
    {
        Console.WriteLine($"Available: {_IsCheckedIn}");
    }
    
 }