using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string StringGrade = Console.ReadLine();
        int NumberGrade = int.Parse(StringGrade);
        string letter = "F";
        string Sign = "";
        
        if ( NumberGrade >= 90)
        {
            letter = "A";
        } else if (NumberGrade >= 80){
            letter = "B";
        } else if (NumberGrade >= 70){
            letter = "C";
        } else if (NumberGrade >= 60){
            letter = "D";
        }
        if (NumberGrade%10 <3 && letter != "F")
        {
            Sign = "-";
        } else if (NumberGrade%10 >= 7 && letter != "F" && letter != "A"){
            Sign = "+";
        }
        Console.WriteLine($"Your grade is a {letter}{Sign}");
        if (NumberGrade >= 70)
        {
            Console.WriteLine($"Congratulation you passed your class");
        } else {
            Console.WriteLine($"You didn't pass this time but we know you can do it just keep trying!");
        }
        
    }
}