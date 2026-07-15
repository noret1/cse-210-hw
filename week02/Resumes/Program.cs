using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world! This is the resumes Project.")
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Noret1 Company";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Engineer";
        job2._company = "Oil & Gas";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Nabukenya Phiona";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
