using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do{
            Console.Clear();
            Console.WriteLine("Welcome to your Mindfulness helper");
            Console.WriteLine("Choose a mindful activity \n 1) Breathing Activity \n 2) Reflecting Activity \n 3) Listing Activity \n 4) Exit Program");
            input = Console.ReadLine();
            if(input == "1")
            {
                BreathingActivity BA = new BreathingActivity();
                BA.StartActivity();
            }
            else if(input == "2")
            {
                ReflectingActivity RA = new ReflectingActivity();
                RA.StartActivity();
            }
            else if(input == "3")
            {
                ListingActivity LA = new ListingActivity();
                LA.StartActivity();
            }
            else if(input == "4")
            {
                break;
            }
        }while(input != "4");
        



        
        
        //Animation.Animation();
        //Animation.Countdown(3,"Breath in");
    }
}