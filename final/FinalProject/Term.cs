abstract class Term 
{
   public string _type = "";
   protected double _value = double.NaN;
   protected bool _IsValid = true;
   public bool IsValid()
   {
      return _IsValid;
   }
   public abstract void Display();
   public abstract double Value();
   public abstract void Assign(List<Term> data);
}