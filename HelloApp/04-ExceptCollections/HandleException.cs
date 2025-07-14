partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {

            // int number = 10;
            // int result = number / 0;

            Write("Enter an amount: ");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount)) return;

            if (double.TryParse(amount, out double amontValue))
            {
                WriteLine($"{amontValue:C}");
            }
            else
            {
                WriteLine("Cannot convert text to a number");
            }

            // double amontValue = double.Parse(amount);
            ValidateAge(16);
        }
        catch (DivideByZeroException)
        {
            WriteLine("Error: Divide by zero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            WriteLine("I dont need '$'");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
        finally
        {
            WriteLine("This will always run");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18) {
            throw new ArgumentException("Age must be over 18");
        } else {
            WriteLine($"I'm {age} years old"); 
        }
    }
}