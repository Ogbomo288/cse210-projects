using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Technician";
        job1._company = "Besley Techno Resource";
        job1._startYear = 2024;
        job1._endYear = 2025;

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Apple";
        job2._startYear = 2026;
        job2._endYear = 2027;

        job2.DisplayJobDetails();

        Console.WriteLine();
        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();


    }

   

}