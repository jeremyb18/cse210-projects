static class Menu
{
    public static void main()
    {
        Console.WriteLine($"\n=============== Welcome to Equation Solver ===============\n");
        Equation EQ;
        Console.WriteLine("Write your Equation below:\n");
        EQ = IO.ReadEquation("- > ");
        Console.WriteLine(EQ.Value());



    
    }
    static void CreateSimpleEquation()
    {

    }
    static void CreateSolveForXEquation()
    {
        
    }
}