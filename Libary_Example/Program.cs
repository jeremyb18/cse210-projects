// See https://aka.ms/new-console-template for more information
Book book = new Book("Hobbit","000220344332", 98733);
book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();


CD cd = new CD("Pirates" , "112229");
cd.Display();
cd.CheckOut();
cd.Display();

cd.ShowCDdetails();
