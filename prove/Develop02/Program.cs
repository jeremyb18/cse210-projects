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
            string CD = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(CD,"*.txt",SearchOption.TopDirectoryOnly);
            for(int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(0,CD.Length+1);
                Console.WriteLine($"{i+1} - {files[i]}");
            }
            int fileChoice = int.Parse(Console.ReadLine());
            if(fileChoice <= files.Length){
                CurrentJournal = new Journal(files[fileChoice-1]);
            }
            
        }
    }
    
    
}


