class Activity
{
    protected string NameOfActivity;
    protected string Message;
    protected int duration;
    protected List<int> Timespacing = new List<int>();
    public Activity()
    {

    }
    public void setTimeSpacing(int NormalSpacing, bool Pairs = false)
    {
        int WholeNumber = (int)duration/NormalSpacing ;
        int Remander = duration - WholeNumber*NormalSpacing;
        for(int i = 0; i < WholeNumber; i++)
        {
            if(Pairs)
            {
                int half = (int)NormalSpacing/2;
                int secondHalf = NormalSpacing/2 > half ? half + 1 : half;
                Timespacing.Add(secondHalf);
                Timespacing.Add(half);
            }
            else
            {
                Timespacing.Add(NormalSpacing);
            }
            
        }
        if(Remander > 0)
        {
            if(Pairs)
            {
                int half = (int)Remander/2;
                int secondHalf = Remander/2 > half ? half + 1 : half;
                Timespacing.Add(secondHalf);
                Timespacing.Add(half);
            }
            else
            {
                Timespacing.Add(Remander);
            }
            
        }

    }
    public void GetReady(int Length)
    {
        string[] Chars =  {"|" , "/" , "-" , "\\" } ;
        for(int i =0; i < Length * 10 ; i++)
        {
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(Chars[i%4] + " Get Ready " + (int)(5 - i/10) + "\n");
        }
    }
    public void CountDown(int Length)
    {
        for(int i =Length; i >= 0 ; i--)
        {
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(i);
        }
    }
    public void Spinner(int Length)
    {
        string[] Chars =  {"|" , "/" , "-" , "\\" } ;
        for(int i =0; i < Length * 10 ; i++)
        {
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write(Chars[i%4]);
        }
    }
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {NameOfActivity}");
        Console.WriteLine($"\n{Message}");
        Console.WriteLine($"How long would you like your activity to take in seconds?");
        duration =  int.Parse(Console.ReadLine());
        activity();
        EndActivity();
    }
    public virtual void activity()
    {
         GetReady(5);
         
    }
    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Congratulation!");
        Spinner(3);  
        Console.Clear();
        Console.WriteLine($"You have completed {duration} seconds of the {NameOfActivity}!");
        CountDown(3);
    }
}