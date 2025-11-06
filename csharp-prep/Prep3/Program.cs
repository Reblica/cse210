using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string user_decision = "";


        do
        {
            Random random_number = new Random();
            int number = random_number.Next(1, 100);
            int quess;
            int total_guesses = 0;

            do
            {
                total_guesses += 1;
                Console.Write("What is your quess? ");
                string answer = Console.ReadLine();
                quess = int.Parse(answer);

                if (quess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (quess < number)
                {
                    Console.WriteLine("Higher");
                }
            } while (quess != number);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {total_guesses} guesses.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Do you wish to play again? (enter 'yes' to continue or 'no' to quit)");
                user_decision = Console.ReadLine();
            } while (user_decision != "yes" && user_decision != "no");
        } while (user_decision != "no");
        Console.WriteLine("Thanks for playing!");
        
    }
}