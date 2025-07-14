/*
=============
🏆 Exercise
==============
*/
// 1. Create a "Bus" class with the following properties:
// - Brand (public)
// - Model (public)
// - Year (public)
// - Price (public)
// - TotalKilometers (public)
//
// 2. Implement a constructor to initialize the values.
// 3. Add a "Drive(int kilometers)" method that increments the mileage.
// 5. Add a "ShowPrice()" method that returns the price of the bus.
// 6. Create a "Fleet" class that manages a list of buses.
// - Method to add buses to the fleet.
// - Method to display the bus list.
//
// 7. Instantiate at least three objects of the Bus class, add them to the Fleet, and simulate driving 5000 vehicles.
// 8. Display the fleet details before and after driving.

using System.Buffers;

partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new Product("Laptop", 1200.99, 5);
        Product mouse = new Product("Mouse", 100, 10);
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);

        laptop.Sell(1);
        inventory.ShowInventory();
    }

    static void BusFleet()
    {
        Fleet fleet = new();
        Bus bus1 = new Bus("Fleet1", "Model1", 2005, 15000, 95000);
        Bus bus2 = new Bus("Fleet2", "Model2", 2020, 42000, 25000);
        Bus bus3 = new Bus("Fleet3", "Model3", 2025, 75000, 100);
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);
        fleet.AddBus(bus3);
        fleet.ShowBuses();

        WriteLine("AFter driving 5000 km...");
        WriteLine("");

        bus1.Drive(5000);
        bus2.Drive(5000);
        bus3.Drive(5000);

        fleet.ShowBuses();


    }
}

class Product
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }


    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ShowInfo()
    {
        WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public bool Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            WriteLine($"Sale made: {quantity} units of {Name}");
            return true;
        }

        WriteLine($"Insufficient stock to {Name}");
        return false;
    }
}

class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowInventory()
    {
        WriteLine("Products Inventory");

        foreach (var product in products)
        {
            product.ShowInfo();
        }
    }
}


class Bus
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public float TotalKilometers { get; set; }

    public Bus(string brand, string model, int year, double price, float totalKilomters)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilomters;
    }

     public void ShowInfo()
    {
        WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, TotalKilometers: {TotalKilometers}");
    }

    public void Drive(int kilometers)
    {
        TotalKilometers += kilometers;
    }

    public void ShowPrice()
    {
        WriteLine($"Price: {Price}");
    }
}

class Fleet
{
    public List<Bus> buses = new();

    public void AddBus(Bus bus)
    {
        buses.Add(bus);
    }

    public void ShowBuses()
    {
        foreach (var bus in buses)
        {
            bus.ShowInfo();
        }
    }

}