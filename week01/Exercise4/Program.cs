using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // don't add the 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("You didn't enter any numbers.");
            return;
        }

        // sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // average (cast so we don't lose the decimals)
        double average = (double)sum / numbers.Count;

        // largest
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        // smallest positive, 0 means none found yet
        int smallestPositive = 0;
        foreach (int n in numbers)
        {
            if (n > 0 && (smallestPositive == 0 || n < smallestPositive))
            {
                smallestPositive = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}