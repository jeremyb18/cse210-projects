static class IO 
{
    static public double ReadDouble(string txt)
    {
        double n;
        bool isNumeric = true;
        do{
            Console.Write(txt);
            string input = Console.ReadLine();
            isNumeric = double.TryParse(input, out n);
        }while(!isNumeric);
        return n;
    }
    static public string Read(string txt)
    {
        Console.Write(txt);
        string input = Console.ReadLine();
        return input;
    }
    static public Equation ReadEquation(string txt)
    {
        bool IsValid = true;
        Equation EQ;
        do{
            Console.Write(txt);
            string input = Console.ReadLine();
            EQ = new Equation(input);
            IsValid = EQ.IsValid;
            if(!IsValid)
            {
                Console.WriteLine("\n----------Error your equation is not valid----------\n");
                Console.WriteLine("Please write a valid equation below:\n");
            }
        }while(!IsValid);
        return EQ; 
    }
}