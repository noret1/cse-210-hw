using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world! look at my Exercise2 project.");

        Console.WriteLine("what is your grade percentage? ");
        string answer = console.ReadLine();
        int percentage = int.Parse(answer);
        string letter = "";


        if (percentage >= 90)
        {
            letter = "A";

        }
        else if (percentage >= 80)
        {
            letter = "B";

        }
        else if (percentage >= 70)
        {
            letter = "C";

        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations on passing this course!");
        }
        else
        {
            Console.WriteLine("Try harder next!");
        }
        
    }
}