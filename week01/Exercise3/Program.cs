using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool  play = true;
        while (play)
        {
            int number = randomGenerator.Next(1, 100);
            int guess = 0;
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (number > guess)
                {
                    Console.Write("Higher ");
                }
                else if (number < guess)
                {
                    Console.Write("Lower ");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }   
            }
            Console.Write("Would you like to play again? yes or no. ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "yes")
            {
                play = false;
            }
        }
    }
}