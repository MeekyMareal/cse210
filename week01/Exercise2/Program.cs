using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        string letter = "";
        string sign = "";
        int grade = int.Parse(userInput);
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }  
        else
        {
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter == "C" && grade > 95)
        {
            sign = "+";
        }
        else if (letter == "A" || letter == "B" || letter == "C" && grade < 95)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have successfully passed the course");
        }
        else
        {
            Console.WriteLine("You failed the course, better luck next time");
        }

    }
}