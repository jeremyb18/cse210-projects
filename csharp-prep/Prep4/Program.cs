using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> Numbers = new List<int>();
        int Number;
        do
        {
            Console.Write("Enter number: ");
            Number = int.Parse(Console.ReadLine());
            if (Number != 0)
            {
                Numbers.Add(Number);
            }
        } while(Number != 0);
        int sum = Numbers.Sum();
        double average = Numbers.Average();
        int Greatest = Numbers.Max();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {Greatest}");
        Numbers.Sort();
        foreach (int x in Numbers)
        {
            if( x > 0){
                Console.WriteLine($"The smallest positive value is {x}");
                break;
            }
        }
        Console.WriteLine("The sorted list is:");
        foreach (int x in Numbers)
        {
            Console.WriteLine(x);
        }
    }
}