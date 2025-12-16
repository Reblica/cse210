public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;

        string[] a = address.Split(",");
        _address = new Address(a[0], a[1], a[2], a[3]);
    }
    
    public string DisplayStandard()
    {
        return $"{_title}\n{_description}\n{_date} {_time}\n{_address.GetAddress()}";
    }
    public string DisplayShort()
    {
        return $"{GetType().Name}, {_title}, {_date}";
    }
    public abstract string DisplayFull();
}