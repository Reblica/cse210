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
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
            
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                
            }
            else if (choice == "4")
            {
                
            }
            
            


    
        }
    }
    public void SaveToFile()
    {
        
    }

    public void LoadToFile()
    {
        
    }
    
        
    
}