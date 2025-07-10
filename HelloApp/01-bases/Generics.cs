partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 25 };

        Console.WriteLine($"Numeric array lenght: {GetIntArrayLenght(numbers)}");
        Console.WriteLine($"Names array lenght: {GetStringArrayLenght(names)}");

        Console.WriteLine($"Numeric array lenght: {GetArrayLenght(numbers)}");
        Console.WriteLine($"Names array lenght: {GetArrayLenght(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "I'm text" };

        numberBox.Show();
        stringBox.Show();
    }

    // Methods without the use of generics
    static int GetIntArrayLenght(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLenght(string[] array)
    {
        return array.Length;
    }

    // Generic method
    static int GetArrayLenght<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content { get; set; }
    public void Show()
    {
        Console.WriteLine($"Content: {Content}");
    }
}