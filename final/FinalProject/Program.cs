using System;
class Program
{
    static void Main(string[] args)
    {
        //string Txt = "1234";
        //Console.WriteLine("Hello World");
        Equation EQ;
        string input = "";
        do
        {
            input = IO.Read("- > ");
            EQ = new Equation(input);
            Console.WriteLine(EQ.Value());

        }while(input != "1"); 

    }
}