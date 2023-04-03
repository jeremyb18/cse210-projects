static class Menu
{
    static MainEquation MainEQ;
    static List<double> Range = new List<double>{-4,4};
    static double SolveStepSize = 0.01;
    static List<string> Options = new List<string>{"Quit"};
    public static void main()
    {
        Console.WriteLine($"\n=============== Welcome to Equation Solver ===============\n");
        NewEquation();
    }
    static void SolveForX()
    {
        double x = Range[0];
        double y;
        double preY = 0;
        List<double> Zeros = new List<double>{};
        while(x < Range[1])
        {
            
            Varible.SetX(x);
            List<double> Values = MainEQ.GetValues();
            if(Values.Count == 2)
            {
                y = Values[0] - Values[1];
            }
            else
            {
                y = Values[0];
            }
            
            if(y * preY < 0 & preY != 0 || y == 0)
            {
                double m = (y-preY)/SolveStepSize;
                double xZero = preY/m + (x - SolveStepSize);
                Zeros.Add(xZero);
            }
            preY = y;
            x += SolveStepSize;
        }
        if(Zeros.Count > 0)
        {
            Console.Write("\nX = ");
            for(int i = 0; i < Zeros.Count; i ++)
            {
                Console.Write($"{Zeros[i]:F3}");
                if(i < Zeros.Count-1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();      
        }
        else
        {
            Console.Write($"\nThere is no solutions for X with the range of {{{Range[0]}, {Range[1]}}}\n");
        }
        Pause();
    }
    static void FindMinMax()
    {
        double x = Range[0];
        double nextY = double.NaN;
        double y = double.NaN;
        double preY = double.NaN;
        List<double[]> Mins = new List<double[]>{};
        List<double[]> Maxs = new List<double[]>{};
        while(x < Range[1] - SolveStepSize)
        {
            preY = y;
            y = nextY;
            Varible.SetX(x);
            List<double> Values = MainEQ.GetValues();
            if(MainEQ.getType() == "XY" || MainEQ.getType() == "X")
            {
                nextY = Values[0];
            }
            else if(MainEQ.getType() == "YX")
            {
                nextY = Values[1];
            }
            if(!double.IsNaN(preY))
            {
                if(y > preY & y > nextY)
                {
                    Maxs.Add( new double[]{x - SolveStepSize,y});
                }
                if(y < preY & y < nextY)
                {
                    Mins.Add(new double[]{x - SolveStepSize,y});
                }
            }
            
            x += SolveStepSize;
        }
        if(Maxs.Count > 0)
        {
            Console.Write("\nMaximums at Points: ");
            for(int i = 0; i < Maxs.Count; i ++)
            {
                Console.Write($"({Maxs[i][0]:F2} , {Maxs[i][1]:F2})");
                if(i < Maxs.Count-1)
                {
                    Console.Write(", ");
                }
            }         
            Console.WriteLine();   
        }
        if(Mins.Count > 0)
        {
            Console.Write("\nMinimums at Points: ");
            for(int i = 0; i < Mins.Count; i ++)
            {
                Console.Write($"({Mins[i][0]:F2} , {Mins[i][1]:F2})");
                if(i < Mins.Count-1)
                {
                    Console.Write(", ");
                }
            }     
            Console.WriteLine();         
        }
        if(Mins.Count == 0 & Maxs.Count == 0)
        {
            Console.Write($"There is no Local Minimums and Maximums for X with the range of {{{Range[0]}, {Range[1]}}} \n");
        }
        Pause();
    }
    static void menu()
    {
        for(int i = 0; i < Options.Count ; i++)
        {
            Console.WriteLine($" {i+1}. {Options[i]}");
        }
        int input = IO.ReadInt("Select a choice from the menu: ") -1;
        switch(Options[input])
        {
            case "Solve For X":
                SolveForX();
                menu();
                break;
            case "Solve for Y=0":
                SolveForX();
                menu();
                break;
            case "Find Local Minimums and Maximums":
                FindMinMax();
                menu();
                break;
            case "Varibles":
                Varibles();
                menu();
                break;
            case "Settings":
                Settings();
                break;
            case "New Equation":
                NewEquation();
                break;
            case "Quit":
                break;
        }
    }
    static void NewEquation()
    {
        Console.WriteLine("Write your Equation below:\n");
        MainEQ = IO.ReadMainEquation("- > ");
        string Type = MainEQ.FindTypeOfEquation();
        if(Type == "S" || Type == "SS")
        {
            Options = new List<string>{"Varibles", "Settings","New Equation" , "Quit"};
            MainEQ.DisplayAnswers();
        }
        else if(Type == "SX" || Type == "XX" || Type == "XS" )
        {
            Options = new List<string>{"Solve For X","Varibles", "Settings","New Equation" , "Quit"};
            MainEQ.DisplayEquation();
        }
        else if(Type == "XY" || Type == "YX" || Type == "X")
        {
            Options = new List<string>{"Solve for Y=0","Find Local Minimums and Maximums", "Varibles" , "Settings","New Equation" , "Quit"};
            MainEQ.DisplayEquation();
        }

        menu();
    }
    static void Settings()
    {
        List<string> SettingOptions = new List<string>{"Range","Step Size","Back"};
        for(int i = 0; i < SettingOptions.Count ; i++)
        {
            Console.WriteLine($" {i+1}. {SettingOptions[i]}");
        }
        int input = IO.ReadInt("Select a choice from the menu: ") -1;
        switch(SettingOptions[input])
        {
            case "Range":
                Console.WriteLine($"Current Range: ({Range[0]}, {Range[1]})");
                Range[0] = IO.ReadDouble("Minimum Range -> ");
                Range[1] = IO.ReadDouble("Maximum Range -> ");
                menu();
                break;
            case "Step Size":
                Console.WriteLine($"Current Step Size: {SolveStepSize}");
                SolveStepSize = IO.ReadDouble("Set Step -> ");
                menu();
                break;
            case "Back":
                menu();
                break;
        }
    }
    static void Pause()
    {
        IO.Read("\nPress Enter to continue:\n");
    }
    public static void Varibles()
    {
        Varible.DisplayVaribles();

        int input = IO.ReadInt("Select a choice from the menu: ") +3;
        Varible.UpdateVarible(input);

    }
}