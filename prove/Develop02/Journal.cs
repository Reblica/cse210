using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO;
using Microsoft.VisualBasic.FileIO;

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
        entry._entryNum = (_entries.Count() + 1).ToString();
        PromptGenerator prompt = new PromptGenerator();
        DateTime CurrentTime = DateTime.Now;
        entry._date = CurrentTime.ToShortDateString();
        entry._prompt = prompt.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        Console.WriteLine();
        string response = Console.ReadLine();
        entry._reponse = response;
        _entries.Add(entry);
    }
    public void SaveToFile()
    {
        Console.WriteLine("Please enter a filename to save your journal: ");
        string filename = Console.ReadLine();

        StreamWriter writeToFile = new StreamWriter(filename);

        foreach (Entry entry in _entries)
        {
            writeToFile.WriteLine($"{entry._entryNum}…{entry._date}…{entry._prompt}…{entry._reponse}");
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

            entry._entryNum = parts[0];
            entry._date = parts[1];
            entry._prompt = parts[2];
            entry._reponse = parts[3];

            _entries.Add(entry);
        }
    }

    public void DeleteEntriesOrSave()
    {
        Console.WriteLine("1. Delete save");
        Console.WriteLine("2. Clear current entries");
    
        string choice = Console.ReadLine();
    
        if (choice == "1")
        {
            Console.WriteLine("Enter a filename save to remove: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine("Delete successful.");
            }
            else
            {
                Console.WriteLine($"Couldn't find {filename}. Exiting to main menu . . .");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("1. Confirm erase of current entries");
            Console.WriteLine("2. Exit to main menu");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                _entries.Clear();
                Console.WriteLine("Sucessfully removed all entries");
            }
            Console.WriteLine("Exiting to main menu. . .");
        }
    }
}