static class Menu
{
    public static void main()
    {
        Console.WriteLine($"\n=============== Welcome to Equation Solver ===============\n");
        Equation EQ;
        Console.WriteLine("Write your Equation below:\n");
        EQ = IO.ReadEquation("- > ");
        EQ.DisplayAnswer();



    
    }
    static void CreateSimpleEquation()
    {

    }
    static void CreateSolveForXEquation()
    {
        
    }
}