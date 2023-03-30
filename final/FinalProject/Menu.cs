static class Menu
{
    static MainEquation MainEQ;
    static List<double> Range = new List<double>{-4,4};
    static double SolveStepSize = 0.01;
    public static void main()
    {
        Console.WriteLine($"\n=============== Welcome to Equation Solver ===============\n");
        Console.WriteLine("Write your Equation below:\n");
        MainEQ = IO.ReadMainEquation("- > ");
        string Type = MainEQ.FindTypeOfEquation();
        Console.WriteLine(Type);
        List<string> Options = new List<string>{"Quit"};
        if(Type == "S")
        {
            Options = new List<string>{"Solve", "View Varibles", "Settings","New Equation" , "Quit"};
        }
        else if(Type == "SX" || Type == "XX" || Type == "XS" )
        {
            Options = new List<string>{"Solve For X","View Varibles", "Settings","New Equation" , "Quit"};
        }

        for(int i = 0; i < Options.Count ; i++)
        {
            Console.WriteLine($" {i+1}. {Options[i]}");
        }
        int input = IO.ReadInt("Select a choice from the menu: ") -1;
        switch(Options[input])
        {
            case "Solve":
                SimpleSolve();
                break;
            case "Solve For X":
                SolveForX();
                break;
            case "View Varibles":
                break;
            case "Settings":
                break;
            case "New Equation":
                main();
                break;
            case "Quit":
                break;
        }
    }
    static void SimpleSolve()
    {
        MainEQ.DisplayAnswers();
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
            y = Values[0] - Values[1];
            Console.Write($"{y} ");
            int Scale = (int)(1/SolveStepSize);
            if(Math.Abs(Scale*x) / Scale == 0) 
            {
                Zeros.Add(Math.Abs(Scale*x) / Scale);
            }
            else if(y * preY < 0 & preY != 0)
            {
                Zeros.Add(Math.Abs(Scale*x) / Scale);
            }
            preY = y;
            x += SolveStepSize;
        }
        if(Zeros.Count > 0)
        {
            Console.Write("X = ");
            for(int i = 0; i < Zeros.Count; i ++)
            {
                Console.Write(Zeros[i]);
                if(i < Zeros.Count-1)
                {
                    Console.Write(",");
                }
            }            
        }
        else
        {
            Console.Write($"There is no solutions for X with the range of {{{Range[0]}, {Range[1]}}}");
        }
    }
    static void XY()
    {

    }
}