public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(string product)
    {
        string[] p = product.Split(":");
        string name = p[0];
        string id = p[1];
        float cost = float.Parse(p[2]);
        int quantity = int.Parse(p[3]);

        Product prod = new Product(name, id, cost, quantity);
        _products.Add(prod);
    }

    public float TotalCost()
    {
        float totalPrice;
        if (_customer.InUS())
        {
            totalPrice = 5;
        }
        else
        {
            totalPrice = 35;
        }
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        return totalPrice;
    }
    public string PackingLabel()
    {
        string product = "";
        foreach (Product p in _products)
        {
            product += p.GetProduct();
        }
        return product;
    }
    public string ShippingLabel()
    {
        return _customer.GetCostumer();
    }
}