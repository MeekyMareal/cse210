using System;
public class Resume
{
    public string _name;
    public Job _jobList;
        
        public void Display()
        {
            Console.WriteLine($"{_name}");
            Console.WriteLine("Job: ");
            _jobList.Display();
        }

}