class MainEquation
{
    public bool IsValid = true;
    List<Equation> _EQs = new List<Equation>{};
    public string _Type;
    public MainEquation(string EQstring)
    {
       List<string>  ListEQ = EQstring.Split("=").ToList();
       if(ListEQ.Count == 1)
       {
            _EQs.Add(new Equation(EQstring));
            IsValid = _EQs[0].IsValid;
       }
       else if(ListEQ.Count == 2)
       {
            foreach(string EQ in ListEQ)
            {
                _EQs.Add(new Equation(EQ));
                if(!_EQs[_EQs.Count-1].IsValid)
                {
                    IsValid = false;
                }
            }
       }
       else 
       {
            IsValid = false;
       }
       _Type = FindTypeOfEquation();
    }
    public string FindTypeOfEquation()
    {
          string TypesOfEquation = "";
          foreach(Equation EQ in _EQs)
          {
               if(EQ.Has("x") & !EQ.Has("y"))
               {
                    TypesOfEquation += "X";
               }
               else if(EQ.HasOnlyY())
               {
                    TypesOfEquation += "Y";
               }
               else if(!EQ.Has("x") & !EQ.Has("y"))
               {
                    TypesOfEquation += "S";
                    
               }
               else
               {
                    IsValid = false;
               }
          }
          
          if(TypesOfEquation == "YY" || TypesOfEquation == "Y")
          {
               IsValid = false;
          }
          return TypesOfEquation;
    }
     public void DisplayAnswers()
    {
          foreach(Equation EQ in _EQs)
          {
               EQ.DisplayAnswer();
               Console.WriteLine();
          }

    }
    public void DisplayEquation()
    {
          Console.WriteLine();
          for(int i = 0; i < _EQs.Count; i++)
          {
               _EQs[i].DisplaySimple();
               if(i == 0)
               {
                    Console.Write(" = ");
               }
          }
          Console.WriteLine();
    }
     public List<double> GetValues()
     {
          List<double> Answers = new List<double>{};
          foreach(Equation EQ in _EQs)
          {
               Answers.Add(EQ.Value());
          }
          return Answers;
     }
}