using System;
using System.Net;

public class Entry
{
    //public string entryNum;
    public string date;
    public string prompt;
    public string reponse;

    public void DisplayEntry()
    {
        Console.WriteLine();
        //Console.WriteLine($"Entry {entryNum}");
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine(reponse);
        Console.WriteLine();
    }
}