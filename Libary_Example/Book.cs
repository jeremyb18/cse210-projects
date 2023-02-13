class Book : LoanAble
{
    private string _ISBN;
    private string _Title;
    private int _UPC;
    public Book(string title, string isbn, int upc)
    {
        _ISBN = isbn;
        _Title = title;
        _UPC = upc;
    }
    public void ShowBookDetails()
    {
        Console.WriteLine($"Title: {_Title} \nISBN:{_ISBN} \nUPC: {_UPC}");
    }
    public override void Display()
    {
        base.Display();
        ShowBookDetails();
    }


}