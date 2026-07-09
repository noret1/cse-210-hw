using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Hello World! look at my Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1; 

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0) 
            {
                numbers.Add(userNumber);
            }
        }
// computing the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
       Console.WriteLine($"The sum is: {sum}");

       //calculate the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
     // finding the max

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                //if the number is greater than the max, then we got the new max
                max = num;
            }
        }
        
        Console.WriteLine($"The largest number is: {max}");
    }
}
