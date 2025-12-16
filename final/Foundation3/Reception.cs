public class Reception : Event
{
    private string _RSVPEmail;

    public Reception(string title, string description, string date, string time, string address, string RSVPEmail) : base(title, description, date, time, address)
    {
        _RSVPEmail = RSVPEmail;
    }

    public override string DisplayFull()
    {
        return $"{DisplayStandard()}\nReception: {_RSVPEmail}";
    }
}