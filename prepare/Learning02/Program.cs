using System;

class Program
{
    static void Main(string[] args)
    {
        

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Infor";
        job1._startYear = 2018;
        job1._endYear = 2020;
        
        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Disney";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._member = "Gavin Cannon";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}