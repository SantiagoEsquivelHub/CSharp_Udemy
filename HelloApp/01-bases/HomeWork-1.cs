// 🏆 Exercise:
// Create a program that calculates a worker's monthly salary
// - Ask the user for their name, hours worked, and hourly rate
// - Calculate the salary and display it on the screen

partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quantity Sold: {quantitySold}");
        Console.WriteLine($"Total: {totalAmount:C}");
    }

    static void SalaryCalculator()
    {
        Console.WriteLine("Salary Calculator");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter worked hours: ");
        double workedHours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter hourly salary: ");
        double hourlySalary = Convert.ToDouble(Console.ReadLine());

        double totalSalary = workedHours * hourlySalary;

        Console.WriteLine($"The salary of {name} is {totalSalary:C}");
    }
}