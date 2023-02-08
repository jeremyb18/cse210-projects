using System;

class Program
{
    static void Main(string[] args)
    {
        string Title = "John 3:16-17";
        string Verse = "16 For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. 17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        int difficulty = 3;
        scripture John = new scripture(Title,Verse);
        WordHidder Mastery = new WordHidder(John);
        
        do
        {
            Console.Clear();
            John.Display();
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Mastery.Hide(difficulty);
            Console.Clear();
        }
        while(Mastery.IsAllHidden() == false);
        John.Display();

    }
}