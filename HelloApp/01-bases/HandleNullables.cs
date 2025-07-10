partial class Program
{
    static void HandleNullables()
    {
        // Non Nullable
        string firstName = "Carlos";

        // Nullable
        string? lastName = null;

        Console.WriteLine($"Name: {firstName}");

        // if (lastName != null)
        // {
        //     Console.WriteLine($"Last name: {lastName}");
        // }
        // else
        // {
        //     Console.WriteLine("Last name not specificated");
        // }

        // Coalescence null operator
        Console.WriteLine($"Last name: {lastName ?? "Last name not specificated"}");

        // Secure null access operator
        string? text = null;
        int? lenght = text?.Length;
    }

}