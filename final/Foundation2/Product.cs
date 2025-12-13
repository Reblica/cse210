public class Product
{
    private string _name;
    private string _id;
    private float _cost;
    private int _quantity;

    public Product(string name, string id, float cost, int quantity)
    {
        _name = name;
        _id = id;
        _cost = cost;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _cost * _quantity;
    }
    public string GetProduct()
    {
        return $"{_name}: {_id}\n";
    }
}