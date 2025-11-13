using System;
using System.ComponentModel;

public class Journal
{
    Entry journal = new Entry();
    List<Entry> _entries = new List<Entry>();

    public void DisplayAllEntries()
    {
        
    }

    public void AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        prompt.GetRandomPrompt();
        journal.reponse = "DEMO TEXT";
        
    }

    public void SaveToFile()
    {
        
    }

    public void LoadToFile()
    {
        
    }



}