using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        string choice = "";

        Console.WriteLine("Welcome to the Journal Age!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            //Console.WriteLine("5. Delete");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                journal.LoadToFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            //else if (choice == "5")
            {
                //journal.DeleteEntryOrSave();
            }
        }
    }
}