using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        if (grade < 97 && grade > 60)
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"You recieved a {sign}{letter} in the class.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed the class.");
        }
        else
        {
            Console.WriteLine("You were unable to pass the class. Remember: 'Success sometimes requires us to fail at least once or twice.'");
        }
    }
}