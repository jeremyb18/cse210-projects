using System;
class Program
{
    static void Main(string[] args)
    {
        //string Txt = "1234";
        //Console.WriteLine("Hello World");
        ReadEquation EQ = new ReadEquation("11(2+1/2) (1+ 3x) /Ca(taw)erf");
        EQ.Separate();
        EQ.Display();
    }
}