// See https://aka.ms/new-console-template for more information

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, string category, int quantity)
    {
        Name = name;
        Price = price;
        Category = category;
        Quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Name: {Name} Price: {Price} Category: {Category} Quantity: {Quantity}");
    }

    public Product subtractQuantity(Product item)
    {
        item.Quantity = item.Quantity - 1;
        return item;
    }
}

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public double Wallet { get; set; }

    List<Product> Basket = new List<Product>();


    public Customer(string name, string email, string address, double wallet)
    {
        Name = name;
        Email = email;
        Address = address;
        Wallet = wallet;
    }

    public Customer SubtractWallet(Customer person, Product item)
    {
        person.Wallet = person.Wallet - item.Price;
        return person;
    }

    public void AddToBasket(Product item)
    {
        Basket.Add(item);
    }

    public void checkOut()
    {
        double total = 0;
        foreach (Product product in Basket)
        {
            product.subtractQuantity(product);
            total += product.Price;
        }
        if (Wallet >= total)
        {
            Wallet -= total;
            Console.WriteLine("Payment successful!");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"Name: {Name} Email: {Email} Address: {Address} Wallet: {Wallet}");
    }
}

class program
{
    static void Main(string[] args)
    {
        Product groupA = new Product("Apple", 15.5, "Fruit", 32);
        Product groupB = new Product("Pear", 25.5, "Fruit", 32);
        Product groupC = new Product("Bluebarry", 9.99, "Fruit", 32);

        Customer personA = new Customer("Erik", "erik@gmail.com", "ågatan 8b stockholm", 100);

        groupA.DisplayProduct();
        groupB.DisplayProduct();
        groupC.DisplayProduct();
        personA.AddToBasket(groupA);
        personA.AddToBasket(groupA);
        personA.AddToBasket(groupB);
        personA.AddToBasket(groupB);
        personA.AddToBasket(groupC);
        personA.checkOut();
        groupA.DisplayProduct();
        groupB.DisplayProduct();
        groupC.DisplayProduct();
        personA.DisplayCustomer();
    }
}