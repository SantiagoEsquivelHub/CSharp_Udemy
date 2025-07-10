partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        // Direct
        int[] numbersArrays = [5, 10, 15, 20, 25, 30];

        // Index
        Console.WriteLine($"First element {numbersArrays[0]}");
        Console.WriteLine($"Third element {numbersArrays[2]}");

        // Array lenght
        Console.WriteLine($"Elements number is {numbersArrays.Length}");

        // Since the end of array
        Console.WriteLine($"Last element {numbersArrays[^1]}");
        Console.WriteLine($"Penultimate element {numbersArrays[^2]}");

        // Range to get subarrays
        int[] firstThree = numbersArrays[..3];
        int[] fromIndexTwo = numbersArrays[2..];

        Console.WriteLine($"First three elements {firstThree}");
        foreach (var number in firstThree)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"From index two {fromIndexTwo}");
        foreach (var number in fromIndexTwo)
        {
            Console.WriteLine(number);
        }
    }

}