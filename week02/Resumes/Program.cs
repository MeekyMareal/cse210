using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobs = new Job();
        jobs._jobTitle = "Front-End Developer";
        jobs._company = "Innovative Web Design";
        jobs._startYear = 2024;
        jobs._endYear = 2025;

        Job jobs2 = new Job();
        jobs2._jobTitle = "Python Programming";
        jobs2._company = "Katche Tech";
        jobs2._startYear = 2023;
        jobs2._endYear = 2024;

        Resume shortResume = new Resume();
        shortResume._name = "George Ekpo";
        shortResume._jobList = jobs;
        shortResume.Display();
        Console.WriteLine($"{jobs2._jobTitle} ({jobs2._company}) {jobs2._startYear} - {jobs2._endYear}");
    }
}