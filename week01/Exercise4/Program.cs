using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput = -1;
        int sum = 0;
        List<int> numbers;
        numbers = new List<int>();

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"Total Sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int maxNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNum)
            {
                maxNum = number;
            }
        }

        Console.WriteLine($"The max is: {maxNum}");
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (smallestPositive == null || num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
        }
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        numbers.Sort();
        Console.WriteLine(string.Join(", ", numbers));
    }
}