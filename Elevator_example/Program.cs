// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<Elevator> Elevators = new List<Elevator>();
        Elevators.Add(new Elevator());
        Elevators.Add(new Elevator());
        Elevators.Add(new Elevator());
        Building Apartment = new Building(20,Elevators);
        Apartment.DisplayBuilding();
        Elevators[0].CallElevator();

    }
}

