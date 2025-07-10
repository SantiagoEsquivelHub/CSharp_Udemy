partial class Program
{
    static void ShowStringType()
    {
        string name = "Santiago";
        string message = "Hello " + name;
        string interpolatedMessage = $"Hola {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"Your name has {name.Length} words.");
        Console.WriteLine($"Your name uppercase is {name.ToUpper()}");
        Console.WriteLine($"Your name lowercase is {name.ToLower()}");

        int number = 13;
        Console.WriteLine(number.ToString());

        bool isString = true;
        Console.WriteLine(isString);


    }
}