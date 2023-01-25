using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journaling program!");
        Console.WriteLine("1 - Create New Journal \n2 - Load Saved Journal\n3- Exit Program");
        int Choice = int.Parse(Console.ReadLine());
        Journal CurrentJournal;
        if( Choice == 1)
        {
            CurrentJournal = new Journal();
        }else if(Choice == 2){
            Console.WriteLine("Choose file to load:");
            string[] files = Directory.GetFiles("C:/Users/jerem/Downloads/CSE210/cse210-projects/prove/Develop02/","*.txt",SearchOption.TopDirectoryOnly);
            for(int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(0,64);
                Console.WriteLine($"{i+1} - {files[i]}");
            }
            int fileChoice = int.Parse(Console.ReadLine());
            CurrentJournal = new Journal(files[fileChoice-1]);
        }
    }
    
    
}


