using System;
class Program
{
    static void Main(string[] args)
    {
        Equation EQ;
        string input = "";
        do
        {
            Console.WriteLine("Write your Equation below:");
            input = IO.Read("- > ");
            EQ = new Equation(input);
            Console.WriteLine(EQ.Value());

        }while(input != "1"); 

    }
}