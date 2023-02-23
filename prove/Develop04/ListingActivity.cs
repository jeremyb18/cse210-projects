class ListingActivity : Activity
{
    private List<string> Prompt = new List<string>{"Who are people that you appreciate?"
                                                ,"What are personal strengths of yours?"
                                                ,"Who are people that you have helped this week?"
                                                ,"When have you felt the Holy Ghost this month?"
                                                ,"Who are some of your personal heroes?"
    };
    public ListingActivity()
    {
        NameOfActivity = "Listing Activity";
        Message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public override void activity()
    {
        base.activity();
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(0, Prompt.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-----{Prompt[RandomNumber]}-----\n");
        DateTime endTime = DateTime.Now.AddSeconds(duration);  
        do{
            Console.Write(" > ");
            string input = Console.ReadLine();
        }while(endTime > DateTime.Now);


    }
}