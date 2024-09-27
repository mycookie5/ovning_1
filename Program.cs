// See https://aka.ms/new-console-template for more information

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }

    public Product(string name, int price, string category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayPrice()
    {
        Console.WriteLine($"Price: {Price}");
    }
}

class program
{
    static void Main(string[] args)
    {
        Product groupA = new Product("Apple", 10000, "Fruit");
        groupA.DisplayPrice();
    }
}