using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),PromptUserNumber());
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static void DisplayResult(string name, int favNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {favNumber*favNumber}");
    }
}