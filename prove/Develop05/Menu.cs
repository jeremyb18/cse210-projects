static class Menu
{
    static List<Goal> Goals = new List<Goal>();
    public static void main()
    {
        Console.WriteLine($"\n=============== Points: {Goal.Totalpoints} ===============\n");
        List<string> Options = new List<string>{"Create New Goal","Record Event", "List Goals", "Save Goals", "Load Goals", "Quit"};
        for(int i = 0; i < Options.Count ; i++)
        {
            Console.WriteLine($" {i+1}. {Options[i]}");
        }
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        switch(input)
        {
            case "1":
                CreateNewGoal();
                break;
            case "2":
                break;
            case "3":
                ListGoals();
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            default:
                main();
                break;
        }
        foreach( Goal goal in Goals)
        {

        }
    }
    public static void CreateNewGoal()
    {
        List<string> Options = new List<string>{"Simple Goal","Eternal Goal", "Check-List Goal", "Back"};
        for(int i = 0; i < Options.Count ; i++)
        {
            Console.WriteLine($" {i+1}. {Options[i]}");
        }
        Console.Write("Select the type of goal you would like to create: ");
        string input = Console.ReadLine();
        
        switch(input)
        {
            case "1":
                Goals.Append(new SimpleGoal());
                break;
            case "2":
                Goals.Append(new EternalGoal());
                break;
            case "3":
                Goals.Append(new EternalGoal());
                break;
            case "4":
                main();
                break;
            default:
                CreateNewGoal();
                break;
        }
        main();
    }
    public static void RecordEvents()
    {

    }
    public static void ListGoals()
    {
        for(int i = 0; i < Goals.Count; i++)
        {
            Console.Write($"\n {i+1}." );
            Goals[i].DisplayGoal();
        }
        Thread.Sleep(3000);
        main();
    }
}