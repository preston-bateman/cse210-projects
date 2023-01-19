using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Fourth Officer";
        job1._company = "White Star Line, SS Celtic";
        job1._startYear = 1880;
        job1._endYear = 1887;
        
        Job job2 = new Job();
        job2._jobTitle = "Ships Captain";
        job2._company = "White Star Line, RMS Titanic";
        job2._startYear = 1912;
        job2._endYear = 1912;

        Resume resume = new Resume();
        resume._name = "Edward Smith";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}