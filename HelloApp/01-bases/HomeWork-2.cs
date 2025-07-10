// 🏆 Exercise:
// Ask the user for their date of birth and calculate how many days until their next birthday.
// Considerations:
// - The entered date of birth must be interpreted correctly,
// ensuring that date comparisons are not affected by time.
// - Research `CultureInfo.InvariantCulture` so that it does not affect the system locale.
// - Handle cases where the birthday has already passed in the current year,
// adding a year to calculate the next birthday (optional).

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(2003, 01, 13);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"You've lived {difference.Days} days");
    }

    static void DaysUntilNextBirthday()
    {
        Console.Write("Enter your birthdate (dd/mm/aaaa)");
        string birthDateString = Console.ReadLine()!;

        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", null);
        DateTime today = DateTime.Today;
        DateTime nextBirthDate = new DateTime(today.Year, birthDate.Month, birthDate.Day);

        if (nextBirthDate < today)
        {
            nextBirthDate = nextBirthDate.AddYears(1);
        }

        int daysUntilNextBirthDate = (nextBirthDate - today).Days;

        Console.WriteLine($"There are {daysUntilNextBirthDate} days left until your next birthday");
    }
}