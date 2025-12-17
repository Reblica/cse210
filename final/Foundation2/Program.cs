class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Customer c1 = new Customer("Randy Nelson", "527,Wichita,KS,US");
        Order o1 = new Order(c1);
        o1.AddProduct("Macbook Pro:020003940KDS:1599.99:3");
        o1.AddProduct("iPad Pro:02002980CPD:999.99:2");

        Console.WriteLine("Products:");
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine(Math.Round(o1.TotalCost(), 2));
        Console.WriteLine();

        Customer c2 = new Customer("Sleapy Gittles", "1443,Berlin,Germany,EU");
        Order o2 = new Order(c2);
        o2.AddProduct("Sweatshirt:400002330STR:14.47:2");
        o2.AddProduct("LED Mount Ceiling Light:200001230MCL:63.39:1");

        Console.WriteLine("Products:");
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine(Math.Round(o2.TotalCost(), 2));
    }
}