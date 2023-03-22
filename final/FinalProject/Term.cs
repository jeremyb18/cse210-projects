abstract class Term 
{
   public static bool IsRunnable = true;
   public string _type = "";
   protected double _value = double.NaN;
   public virtual void SetVarible()
   {

   }
   public abstract void Display();
   public abstract double Value();
   public abstract void Assign(List<Term> data);
}