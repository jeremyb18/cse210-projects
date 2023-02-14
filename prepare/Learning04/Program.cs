using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment Week6 = new MathAssignment("Jeremy","Differential Equations","1.6", "5-6");
        WrittingAssignment Midterms = new WrittingAssignment("Jeremy","REL 250 Jesus Christ Everlasting Gospel","Fiath is not Blind");
        Week6.GetHomeworkList();
        Midterms.GetWrittingInformation();
    }
}