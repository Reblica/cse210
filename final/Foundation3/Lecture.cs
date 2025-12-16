public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int maxCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override string DisplayFull()
    {
        return $"{DisplayStandard()}\nLecture: {_speaker}, {_maxCapacity}";
    }
}