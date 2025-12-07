public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int awardedPoints) : base(name, description, awardedPoints)
    {
    }
    public EternalGoal(string fileGoal)
    {
        string[] eternalGoal = fileGoal.Split("…");

        SetName(eternalGoal[0]);
        SetDescription(eternalGoal[1]);
        SetAwardedPoints(int.Parse(eternalGoal[2]));
        AddPoints(GetAwardedPoints());
    }
    public static EternalGoal CreateGoal()
    {
        Console.Write("What was the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int awardedPoints = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, awardedPoints);
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override void RecordEvent()
    {
        AddPoints(GetAwardedPoints());
    }
    public override string SaveGoal()
    {
        return $"{GetName()}…{GetDescription()}…{GetAwardedPoints()}…{GetPoints()}";
    }
}