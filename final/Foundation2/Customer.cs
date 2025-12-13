public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string address)
    {
        _name = name;
        
        string[] a = address.Split(",");
        _address = new Address(a[0], a[1], a[2], a[3]);
    }

    public bool InUS()
    {
        if (_address.GetCountry() == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetCostumer()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }
}