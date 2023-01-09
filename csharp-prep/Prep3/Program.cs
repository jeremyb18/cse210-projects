using System;

class Program
{
    static void Main(string[] args)
    {
        string PlayAgain;
        do
        {
            Random randomGenerator = new Random();
            int MajicNumber = randomGenerator.Next(1, 11);
            int Guess;
            int NumberOfGuesses = 0;
            do 
            {
                NumberOfGuesses++;
                Console.Write("What is your guess? ");
                Guess = int.Parse(Console.ReadLine());
                if (Guess > MajicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if(Guess < MajicNumber)
                {
                    Console.WriteLine("Higher");
                }else{
                    Console.WriteLine($"You guessed it with only {NumberOfGuesses} guesses");
                }
            } while (Guess != MajicNumber);
            Console.Write("Do you want to play agian? ");
            PlayAgain = Console.ReadLine();
        } while(PlayAgain == "yes" || PlayAgain == "Yes");

    }
}