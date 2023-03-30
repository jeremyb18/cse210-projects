abstract class Term 
{
   public string _type = "";
   protected double _value = double.NaN;
   public bool IsValid = true;
   public abstract void Display();
   public abstract double Value();
   public abstract void Assign(List<Term> data);
}