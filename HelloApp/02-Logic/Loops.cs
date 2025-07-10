partial class Program
{
    static void Loops()
    {
        // while

        int counter = 1;

        while (counter <= 5)
        {
            WriteLine($"Iteration while: {counter}");
            counter++;
        }

        // do while

        int number = 0;

        do
        {
            WriteLine($"Number: {number}");
            number++;
        } while (number < 3);

        // for

        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Iteration for: {i}");
        }

        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }

        // foreach

        // 1. Array
        string[] fruits = ["Apple", "Pear", "Pineapple"];
        foreach (var fruit in fruits)
        {
            WriteLine(fruit);

        }

        // 2. List
        List<string> names = ["Pedro", "Luis", "Nancy"];
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}