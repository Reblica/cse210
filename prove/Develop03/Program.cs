using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string[][] scriptures = [["Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unot thine own understanding; in all thy ways acknowledg him, and he shall direct they paths."], 
        ["John 3:6", "For God so loved the world. that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."], 
        ["Mosiah 4:9", "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend."], 
        ["D&C 115:4", "For thus shall my church be called in the last days, even The Church of Jesus Christ of Latter-Day Saints."]];
        

        Scripture scripture = new Scripture(scriptures);
        scripture.GetRenderedText();
        choice = Console.ReadLine();

        while (choice != "quit" && scripture.IsCompletelyHidden() != true)
        {
            scripture.HideWords();
            scripture.GetRenderedText();
            choice = Console.ReadLine();
        }

    }
}