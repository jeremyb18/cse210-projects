using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(5);
        Console.WriteLine(f.getFractionString());
        Console.WriteLine(f.getDecimalValue());
        f.setTop(4);
        f.setBottom(5);
        Console.WriteLine(f.getFractionString());
        Console.WriteLine(f.getDecimalValue());
        f.setTop(6);
        Console.WriteLine(f.getFractionString());
        Console.WriteLine(f.getDecimalValue());
        f.setTop(1);
        f.setBottom(3);
        Console.WriteLine(f.getFractionString());
        Console.WriteLine(f.getDecimalValue());
        
    }
}