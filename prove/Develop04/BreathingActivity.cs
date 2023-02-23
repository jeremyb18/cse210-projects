class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        NameOfActivity = "Breathing Activity";
        Message = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public override void activity()
    {
        base.activity();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration * 1000);
        List<string> TextAnimation = new List<string>{" ","/","//","///","////","/////","//////","///////"};
        setTimeSpacing(10, Pairs:true);
        for(int t = 0; t < Timespacing.Count ; t++)
        {
            for(int i =Timespacing[t]; i > 0 ; i--)
            {
                Console.Clear();
                if(t%2 == 0)
                {
                    Console.WriteLine($"{TextAnimation[Timespacing[t]- i]}");
                    Console.WriteLine($"{"Breath in"} {i}");
                    Console.WriteLine($"{TextAnimation[Timespacing[t] - i]}");
                }else{
                    Console.WriteLine($"{TextAnimation[i]}");
                    Console.WriteLine($"{"Breath out"} {i}");
                    Console.WriteLine($"{TextAnimation[i]}");
                }
                
                Thread.Sleep(1000);  
            }
        }
        
    }
    
}