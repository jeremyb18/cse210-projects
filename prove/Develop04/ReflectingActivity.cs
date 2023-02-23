class ReflectingActivity : Activity
{
    private List<string> Prompt = new List<string>{"Think of a time when you stood up for someone else."
                                                , "Think of a time when you did something really difficult."
                                                , "Think of a time when you helped someone in need."
                                                , "Think of a time when you did something truly selfless."};
    private List<string> DeeperPrompt = new List<string>{"Why was this experience meaningful to you?"
                                                        , "Have you ever done anything like this before?"
                                                        , "How did you get started?"
                                                        , "How did you feel when it was complete?"
                                                        , "What made this time different than other times when you were not as successful?"
                                                        , "What is your favorite thing about this experience?"
                                                        , "What could you learn from this experience that applies to other situations?"
                                                        , "What did you learn about yourself through this experience?"
                                                        , "How can you keep this experience in mind in the future?"};
    public ReflectingActivity()
    {
        NameOfActivity = "Breathing Activity";
        Message = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";   
    }
    public override void activity()
    {
        base.activity();
        
        Random randomGenerator = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration); 
        int RandomNumber = randomGenerator.Next(0, Prompt.Count);
        Console.WriteLine($"Consider the following promt:\n");
        Console.WriteLine($"-----{Prompt[RandomNumber]}-----\n");
        Console.WriteLine($"When you have something in mind press any key");
        Console.ReadLine();
        int sD = duration;
        duration = (endTime - DateTime.Now).Seconds;
        setTimeSpacing(10);
        duration = sD;
        string message = "";
        for(int t = 0; t < Timespacing.Count ; t++)
        {   
                RandomNumber = randomGenerator.Next(0, DeeperPrompt.Count);
                message = DeeperPrompt[RandomNumber];
            
            for(int i =Timespacing[t]; i > 0 ; i--)
            {
                Console.Clear();
                Console.WriteLine($"{message} {i}");
                Thread.Sleep(1000); 
            }

        }
        
        
        

    }
}