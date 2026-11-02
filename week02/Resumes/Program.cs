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

        Resume shortResume = new Resume();
        shortResume._name = "George Ekpo";
        shortResume._jobList = jobs;
        shortResume.Display();
    }
}