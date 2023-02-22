using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");

            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;
            foreach (int sumNumber in numbers)
            {
                sum += sumNumber;
            }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int maxNumber in numbers)
        {
            if (maxNumber > max)
            {
                max = maxNumber;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}