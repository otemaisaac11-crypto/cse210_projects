using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a number (0 to quit):");
        int number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            Console.WriteLine("Enter a number (0 to quit):");
            number = int.Parse(Console.ReadLine());
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of numbers is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}