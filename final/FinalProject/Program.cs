using System;
class Program
{
    static void Main(string[] args)
    {
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