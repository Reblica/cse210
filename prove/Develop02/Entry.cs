using System;
using System.Net;

public class Entry
{
    public string _entryNum;
    public string _date;
    public string _prompt;
    public string _reponse;

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Entry {_entryNum}");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_reponse);
        Console.WriteLine();
    }
}