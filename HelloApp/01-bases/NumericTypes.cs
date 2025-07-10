partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416d;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;

        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Floating: {floatingNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Decimal: {monetaryNumber}");

    }
}