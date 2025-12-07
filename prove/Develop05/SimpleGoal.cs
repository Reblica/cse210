public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int awardedPoints) : base(name, description, awardedPoints)
    {
        _isCompleted = false;
    }
    public SimpleGoal(string fileGoal)
    {
        string[] simpleGoal = fileGoal.Split("…");

        SetName(simpleGoal[0]);
        SetDescription(simpleGoal[1]);
        SetAwardedPoints(int.Parse(simpleGoal[2]));
        _isCompleted = bool.Parse(simpleGoal[3]);
        if (_isCompleted == true)
        {
            AddPoints(GetAwardedPoints());
        }
        else
        {
            AddPoints(0);
        }
    }
    public static SimpleGoal CreateGoal()
    {
        Console.Write("What was the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int awardedPoints = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, description, awardedPoints);
    }
    public override void DisplayGoal()
    {
        if (_isCompleted == false)
        {
            Console.Write("[ ] ");
        }
        else
        {
            Console.Write("[x] ");
        }
        Console.WriteLine($"{GetName()} ({GetDescription()})");
    }
    public override bool IsCompleted()
    {
        return _isCompleted;
    }
    public override void RecordEvent()
    {
        if (_isCompleted == false)
        {
            _isCompleted = true;
            AddPoints(GetAwardedPoints());
        }
    }
    public override string SaveGoal()
    {
        return $"{GetName()}…{GetDescription()}…{GetAwardedPoints()}…{_isCompleted}";
    }
}