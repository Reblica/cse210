using System;
using System.ComponentModel;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAllEntries()
    {
        foreach (Entry entries in _entries)
        {
            entries.DisplayEntry();
        }
    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        //entry.entryNum = (_entries.Count()).ToString();
        PromptGenerator prompt = new PromptGenerator();
        DateTime CurrentTime = DateTime.Now;
        entry.date = CurrentTime.ToShortDateString();
        entry.prompt = prompt.GetRandomPrompt();
        Console.WriteLine(entry.prompt);
        Console.WriteLine();
        string response = Console.ReadLine();
        entry.reponse = response;
        _entries.Add(entry);
    }
    public void SaveToFile()
    {
        Console.WriteLine("Please enter a filename to save your journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writeToFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writeToFile.WriteLine($"{entry.date}…{entry.prompt}…{entry.reponse}");
                //writeToFile.WriteLine($"{entry.entryNum}…{entry.date}…{entry.prompt}…{entry.reponse}");
            }
        }
    }

    public void LoadToFile()
    {
        Console.WriteLine("Please enter the filename you want to load: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split("…");

            //entry.entryNum = parts[0];
            entry.date = parts[0];
            entry.prompt = parts[1];
            entry.reponse = parts[2];

            _entries.Add(entry);
        }
    }

    //public void DeleteEntryOrSave()
    //{
    //    Console.WriteLine("1. Delete a entry");
    //    Console.WriteLine("2. Delete save");
    //    Console.WriteLine("3. Clear entries");
    //
    //    string choice = Console.ReadLine();
    //
    //    if (choice == "1")
    //    {
    //        Console.WriteLine("Please enter the entry number you wish to delete.");
    //        
    //        foreach (Entry entry in _entries)
    //        {
    //            entry.DisplayEntry();
    //        }
    //    }
    //}
}