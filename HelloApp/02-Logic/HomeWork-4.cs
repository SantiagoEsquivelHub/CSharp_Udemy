// 🏆 Exercise:
// Create a method called `PrintFactorialTable` that receives a number
// and displays the factorial of all numbers from 1 to the entered number.
// Example: PrintFactorialTable(5);
// 1! = 1
// 2! = 2
// 3! = 6
// 4! = 24
// 5! = 120
partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit)
    {
        WriteLine($"Multiplication table of the number {number} from 1 to {tableLimit}");

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i}= {number * i}");
        }
        WriteLine();
    }

    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial of number {number} from 1 to {number}");

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {factorial}");
            factorial *= i + 1;
        }

    }

}