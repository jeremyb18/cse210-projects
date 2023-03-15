class Equation
{
    string EQstring = "";
    char[] CharArray;
    List<string> Elements = new List<string>{};
    List<string> Operators = new List<string>{"+","-","*","(",")","^","="};
    public Equation(string Input)
    {
        EQstring = Input.Replace(" ", "").ToLower();
        EQstring = EQstring.Replace("sin", "$");
        EQstring = EQstring.Replace("cos", "@");
        CharArray = EQstring.ToCharArray();
        Console.WriteLine(EQstring);
    }
    private void Separate()
    {
        int n;
        for(int i = 0; i < EQstring.Length;i++)
        {
            string chr = EQstring[i].ToString();
            if(int.TryParse(EQstring[i].ToString(), out n))
            {

            }
          //  switch(EQstring[i])
         //   {
                //case int.TryParse(EQstring[i], out n):
                //CreateNewGoal();
                //break;
           // case "2":
                //RecordEvents();
               // break;
          //  case "3":
                //ListGoals();
              //  break;
          //  }
        }
    }
    private bool IsOperator(string C)
    {
        foreach(string Operator in Operators)
        {
            if(Operator == C)
            {
                return true;
            }
        }
        return false;
    }
    private string IsNumber(string EQstring, int idx,string preString)
    {
        int n;
        if(int.TryParse(EQstring[idx].ToString(), out n))
        {
            return EQstring[idx].ToString();
        }
        return "";
    }
}