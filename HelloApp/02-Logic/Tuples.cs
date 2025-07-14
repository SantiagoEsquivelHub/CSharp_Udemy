partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = new(42, "Hi");
        WriteLine($"Number: {myTuple.Item1}, Text: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = new(33, "Named");
        WriteLine($"Number: {myOtherTuple.Number}, Text: {myOtherTuple.Text}");

        var operations = Operations(20, 10);
        WriteLine($"Add: {operations.Sum}, Text: {operations.Subtraction}");

        (int sum, int subtraction) = Operations(20, 10);
        WriteLine($"Add: {sum}, Text: {subtraction}");
    }

    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}