class MainEquation
{
    public bool IsValid = true;
    List<Equation> _EQs = new List<Equation>{};
    
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
       FindTypeOfEquation();
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
               else
               {
                    TypesOfEquation += "S";
               }
          }
          if(_EQs.Count == 1)
          {
               if(TypesOfEquation[0].ToString() == "X")
               {
                    TypesOfEquation += "Y";
               }
               if(TypesOfEquation[0].ToString() == "Y")
               {
                    TypesOfEquation = "S";
               }
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