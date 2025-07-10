partial class Program
{
    static void DataStructure()
    {
        User pedro = new User { Name = "Pedro", Age = 33 };
        pedro.Greet();

        Point point = new Point { X = 30, Y = 20 };
        Console.WriteLine($"Point ({point.X}, {point.Y})");

        CellPhone cellphone = new CellPhone("Nokia 225", 2024);
        Console.WriteLine(cellphone);

    }

    class User
    {

        public string? Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, I am the user {Name} and I am {Age} years old");
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    record CellPhone(string Model, int Year);
}