public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string DisplayFull()
    {
        return $"{DisplayStandard()}\nOutdoorGathering: {_weather}";
    }
}