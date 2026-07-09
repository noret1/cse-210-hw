using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world! look at my Exercise1 project.");

        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }

}

