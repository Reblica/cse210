public abstract class Goal
{
    private int _points;
    private string _name;
    private string _description;
    private int _awardedPoints;

    public Goal(string name, string description, int awardedPoints)
    {
        _name = name;
        _description = description;
        _awardedPoints = awardedPoints;
        _points = 0;
    }
    protected Goal()
    {
    }

    public int GetPoints()
    {
        return _points;
    }
    protected void AddPoints(int points)
    {
        _points += points;
    }
    public string GetName()
    {
        return _name;
    }
    protected void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    protected void SetDescription(string description)
    {
        _description = description;
    }
    public int GetAwardedPoints()
    {
        return _awardedPoints;
    }
    protected void SetAwardedPoints(int awardedPoints)
    {
        _awardedPoints = awardedPoints;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string SaveGoal();
    public abstract void DisplayGoal();
}