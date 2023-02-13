class CD : LoanAble
{
    string _Title;
    string _UPC;
    public CD(string title,string upc)
    {
        _Title = title;
        _UPC = upc;
    }

    public void ShowCDdetails()
    {
        Console.WriteLine($"Title: {_Title} \nUPC: {_UPC}");
    }
}