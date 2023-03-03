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
                RecordEvents();
                break;
            case "3":
                ListGoals();
                break;
            case "4":
                ReadWriteFile.Write(Goals);
                Console.WriteLine("You have successfully saved your goals!");
                Thread.Sleep(2000);
                main();
                break;
            case "5":
                Goals = ReadWriteFile.Read();
                Console.WriteLine("You have successfully loaded your goals!");
                Thread.Sleep(2000);
                main();
                break;
            case "6":
                Console.WriteLine("Good Luck with your goals!");
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
                Goals.Add(new SimpleGoal());
                break;
            case "2":
                Goals.Add(new EternalGoal());
                break;
            case "3":
                Goals.Add(new ChecklistGoal());
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
        List<int> currentGoals = new List<int>();
        for(int i = 0; i < Goals.Count; i++)
        {
            if (!Goals[i].Isachieved())
            {
                currentGoals.Add(i);
            }
        }
        for(int i = 0; i < currentGoals.Count; i++)
        {
                int CG = currentGoals[i];
                Console.Write($"\n {i+1}. " );
                Goals[CG].DisplayGoal();
        }
        if(currentGoals.Count == 0)
        {
            Console.WriteLine("You have no goals at the moment");
        }
        Console.WriteLine($"{currentGoals.Count+1}. Back" );
        int input = IO.ReadInt("Choose an option: ") - 1;
        if (input == currentGoals.Count)
        {
            main();
        }
        else if(input < currentGoals.Count)
        {
            int idx = currentGoals[input];
            Goals[idx].RecordEvent();
            main();
        }
        else
        {
            RecordEvents();
        }
        
        
    }
    public static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($"\n You have {Goals.Count} goals:");
        for(int i = 0; i < Goals.Count; i++)
        {
            Console.Write($"\n {i+1}." );
            Goals[i].DisplayGoal();
        }
        Console.WriteLine($"\nPress any enter to continue:" );
        Console.Read();
        main();
    }
}