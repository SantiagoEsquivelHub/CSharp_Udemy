partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2021;
        toyota.ShowInfo();

        Vehicle honda = new Vehicle { Brand = "Honda", Model = "Civic", Year = 2019 };
        honda.ShowInfo();

        Vehicle renault = new Vehicle("Renault", "Duster", 2024);
        renault.ShowInfo();

    }
}

class Vehicle
{

    // Properties
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    // Constructor

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle(){}

    // Methods
    public void ShowInfo()
    {
        WriteLine($"This vehicle is a {Brand} {Model} of the year {Year}");
    }
}