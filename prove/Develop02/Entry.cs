using System;
using System.Net;

public class Entry
{

    public string reponse;
    public string date = "11/13/2025";
    public void StoreEntry()
    {

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"");
    }
}