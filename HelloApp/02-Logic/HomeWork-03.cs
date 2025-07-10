// 🏆 Exercise:
// Implement a program that loops through the numbers from 1 to 100.
// Considerations:
// Apply FizzBuzz logic:
// - If a number is divisible by 3, print "Fizz".
// - If a number is divisible by 5, print "Buzz".
// - If a number is divisible by both 3 and 5, print "FizzBuzz".
// - Otherwise, print the number.
// 💡 Hint:
// - The order of the conditions is key.
// Think about how to ensure that "FizzBuzz" is printed before "Fizz" or "Buzz".

partial class Program
{
    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {

            string message;
            bool multipleOfThree = i % 3 == 0;
            bool multipleOfFive = i % 5 == 0;

            if (multipleOfThree && multipleOfFive)
            {
                message = "FizzBuzz";
            }
            else if (multipleOfThree)
            {
                message = "Fizz";
            }
            else if (multipleOfFive)
            {
                message = "Buzz";
            }
            else
            {
                message = i.ToString();
            }

            WriteLine(message);

        }
    }
}