partial class Program
{
    static void Methods()
    {
        Car car = new Car();

        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.showMessage();
        // car.showMessage("Changing of model");
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        Car sportCar = new Car("Ferrari", 2020);
        WriteLine(sportCar.ShowInfo());

        Car colletionCar = new Car { Model = "Cadillac", Year = 1980 };
        WriteLine(colletionCar.ShowInfo());

        WriteLine("Cars list: ");

        List<Car> cars = new()
        {
            new Car(){Model = "Duster", Year = 2021},
            new Car(){Model = "Stepway", Year = 2019},
            new Car(){Model = "Captur", Year = 2000},
        };

        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }

    }
}

class Car
{

    public string? Model { get; set; }
    public int? Year { get; set; }

    // Params contructor
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    // Default constructor
    public Car() { }

    // Destructor
    ~Car()
    {
        WriteLine("Destructor called. Released resource");
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Car: {Model}, Year: {Year}";
    }

    public void showMessage() => WriteLine("This is a car");
    public void showMessage(string message) => WriteLine(message);

    public static void GeneralInfo()
    {
        WriteLine("The car is one of the most used means of transport");
    }
}