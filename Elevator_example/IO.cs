static class IO 
{
    static public int ReadInt(string txt)
    {
        int n;
        bool isNumeric = true;
        do{
            Console.Write(txt);
            string input = "1";//Console.ReadLine();
            isNumeric = int.TryParse(input, out n);
        }while(!isNumeric);
        return n;
    }
}