using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void PromptUserName(ref string name)
    {
        Console.Write("What is you name? ");
        name = Console.ReadLine();
    }

    static void PromptUserNumber(ref int fav_num)
    {
        Console.Write("What is you favorite number? ");
        string number = Console.ReadLine();
        fav_num = int.Parse(number);
    }

    static void PromptUserBirthYear(out int bir_year)
    {
        Console.Write("What year where you born? ");
        string year = Console.ReadLine();
        bir_year = int.Parse(year);
    }

    static void SquareNumber(ref int number)
    {
        number = number * number;
    }

    static void DisplayResult(string name, int number, int bir_year)
    {
        var date_time = DateTime.Today;
        Console.WriteLine($"{name}, the square of your number is {number}");
        int age = date_time.Year - bir_year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        string name = "";
        int fav_num = 0;
        int bir_year;
        DisplayWelcome();
        PromptUserName(ref name);
        PromptUserNumber(ref fav_num);
        PromptUserBirthYear(out bir_year);
        int fav_num_square = fav_num;
        SquareNumber(ref fav_num_square);
        DisplayResult(name, fav_num_square, bir_year);
    }
}