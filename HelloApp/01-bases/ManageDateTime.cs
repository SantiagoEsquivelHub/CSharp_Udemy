using System.Data;

partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime nowWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 07, 01);

        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($"Current date and time: {now}");
        Console.WriteLine($"Current date: {today}");
        Console.WriteLine($"A week ago the date {now} was : {nowWeekAgo}");
        Console.WriteLine($"Custom date: {customDate}");
        Console.WriteLine($"Week day: {weekDay}");

    }
}