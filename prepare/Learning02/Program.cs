using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Digital Print Machine Operator";
        job1._company = "HandStands Promo";
        job1._startYear = 2020;
        job1._endYear = 2020;
        //job1.Display();
        Job job2 = new Job();
        job2._jobTitle = "Product Design Engineer Intern";
        job2._company = "EJ Engineering";
        job2._startYear = 2020;
        job2._endYear = 2020;
        //job2.Display();
        Job job3 = new Job();
        job3._jobTitle = "Lake Maintenance Specialist";
        job3._company = "Stansbury Park Services";
        job3._startYear = 2022;
        job3._endYear = 2022;
        //job3.Display();
        Resume myResume = new Resume();
        myResume._name = "Jeremy Ruebush";
        myResume._jobs = new List<Job>{job1,job2,job3};
        myResume.Display();

    }
}

