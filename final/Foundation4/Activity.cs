public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public virtual double GetPace()
    {
        return _length / GetDistance();
    }
    public virtual double GetDistance()
    {
        return GetSpeed() / 60 * _length;
    }

    public string DisplaySummery()
    {
        return $"{_date} {GetType().Name} ({_length} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}