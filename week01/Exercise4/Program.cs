using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string response = Console.ReadLine();
            newNumber = int.Parse(response);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int sum = 0;
        // calculating the sum
        foreach (int number in numbers)
        {
            sum += number;

        }
        // computing the sum
        Console.WriteLine($"The sum is: {sum}");
        // calculating the average
        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average number is: {average}");
        // calculating the maximum number
        int max = -1;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");     
    }

}