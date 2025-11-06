using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int largest_number = 0;
    
        Console.WriteLine("Enter a list of numbers, enter '0' when finished.");

        Console.Write("Enter number: ");
        string answer = Console.ReadLine();
        number = int.Parse(answer);
        int smallest_number = number;

        while (number != 0)
        {
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                if (number > largest_number)
                {
                    largest_number = number;
                }
                if (number < smallest_number && number > 0)
                {
                    smallest_number = number;
                }
            }
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            number = int.Parse(answer);
        }
        float average = sum / float.Abs(numbers.Count);

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest number is: {smallest_number}");

        Console.WriteLine("The sorted list is:");
        foreach (int digit in numbers)
        {
            Console.WriteLine(digit);
        }

        

    }
}