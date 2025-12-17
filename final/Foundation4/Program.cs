class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Console.Clear();

        Running r1 = new Running("02-04-2027", 30, 3);
        activities.Add(r1);

        Swimming s1 = new Swimming("05-17-2027", 15, 32);
        activities.Add(s1);

        Cycling c1 = new Cycling("07-01-2027", 50, 10);
        activities.Add(c1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($" • {activity.DisplaySummery()}");
        }
    }
}