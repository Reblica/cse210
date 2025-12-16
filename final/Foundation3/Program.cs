class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lecture l1 = new Lecture("TED Talk", "Come and listen to Daniel speak on the devastating impact of artifical intelligence in his life.", "01-04-2026", "12:00:00 MST", "120th street,Manhattan,New York,US", "Daniel Parsely", 49);
        Console.WriteLine(l1.DisplayStandard());
        Console.WriteLine();
        Console.WriteLine(l1.DisplayFull());
        Console.WriteLine();
        Console.WriteLine(l1.DisplayShort());
        Console.WriteLine();

        Reception r1 = new Reception("Festival Concert", "Watch what the orchestra has prepared and will play at the high school", "12-04-2026", "18:30:00 MST", "201 Piningville,Wichita,KS,US", "registertoday@rsvp.com");
        Console.WriteLine(r1.DisplayStandard());
        Console.WriteLine();
        Console.WriteLine(r1.DisplayFull());
        Console.WriteLine();
        Console.WriteLine(r1.DisplayShort());
        Console.WriteLine();

        OutdoorGathering o1 = new OutdoorGathering("Biking Marathon", "Join to bike with tons of bikers to connect with for company", "06-20-2026", "09:00:00 MST", "1551 West Nancy Creek Drive,Brookhaven,Georgia,US", "Clear");
        Console.WriteLine(o1.DisplayStandard());
        Console.WriteLine();
        Console.WriteLine(o1.DisplayFull());
        Console.WriteLine();
        Console.WriteLine(o1.DisplayShort());
    }
}