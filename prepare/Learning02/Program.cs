using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Lead Engineer";
        job1._startYear = 2024;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._company = "Sony";
        job2._jobTitle = "Head Designer";
        job2._startYear = 2012;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}