public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private bool _isCompleted;
    private int _requiredCompletion;
    private int _currentCompleted;
    public ChecklistGoal(string name, string description, int awardedPoints, int requiredCompletion, int bonusPoints) : base(name, description, awardedPoints)
    {
        _bonusPoints = bonusPoints;
        _requiredCompletion = requiredCompletion;
        _currentCompleted = 0;
        _isCompleted = false;
    }
    public ChecklistGoal(string filegoal)
    {
        string[] checklistGoal = filegoal.Split("…");

        SetName(checklistGoal[0]);
        SetDescription(checklistGoal[1]);
        SetAwardedPoints(int.Parse(checklistGoal[2]));
        _bonusPoints = int.Parse(checklistGoal[3]);
        _requiredCompletion = int.Parse(checklistGoal[4]);
        _currentCompleted = int.Parse(checklistGoal[5]);
        if (_currentCompleted >= _requiredCompletion)
        {
            _isCompleted = true;
        }
        else
        {
            _isCompleted = false;
        }
        AddPoints(int.Parse(checklistGoal[6]));
    }
    public static ChecklistGoal CreateGoal()
    {
        Console.Write("What was the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int awardedPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        int requiredCompletion = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("What is the bonus for completing the goal that set amount of times? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, awardedPoints, requiredCompletion, bonusPoints);
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
        Console.WriteLine($"{GetName()} ({GetDescription()}) -- Currently Completed: {_currentCompleted}/{_requiredCompletion}");
    }
    public override bool IsCompleted()
    {
        return _isCompleted;
    }
    public override void RecordEvent()
    {
        _currentCompleted++;
        if (_currentCompleted == _requiredCompletion)
        {
            AddPoints(_bonusPoints);
            _isCompleted = true;
        }
        else if (_currentCompleted < _requiredCompletion)
        {
            AddPoints(GetAwardedPoints());
        }
    }
    public override string SaveGoal()
    {
        return $"{GetName()}…{GetDescription()}…{GetAwardedPoints()}…{_bonusPoints}…{_requiredCompletion}…{_currentCompleted}…{GetPoints()}";
    }
}