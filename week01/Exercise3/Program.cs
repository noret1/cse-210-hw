using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! look at my Exercise 3 Project. ");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1; 

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it right!");
    }
}
