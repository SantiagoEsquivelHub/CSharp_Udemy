using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-CO");

        int friends = int.Parse("101");
        double entraceCost = 25.50;
        DateTime birthday = DateTime.Parse("2 Marzo 2025");

        WriteLine($"I have {friends} friends to invite to my party");
        WriteLine($"My birthday celebration will be {birthday}");
        WriteLine($"Long format: {birthday:D}");
        WriteLine($"Entrace cost will be: {entraceCost:C}");

    }
}