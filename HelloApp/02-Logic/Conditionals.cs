partial class Program
{
    static void Conditionals()
    {

        // If

        int age = 19;
        if (age >= 18)
        {
            WriteLine("You are an adult");
        }
        else
        {
            WriteLine("You are a minor");
        }

        string message = age >= 18 ? "You are an adult" : "You are a minor";
        WriteLine(message);

        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("It's hot");
        }
        else if (temperature >= 20)
        {
            WriteLine("It's pleasent");
        }
        else
        {
            WriteLine("It's cold");
        }

        // Switch

        int day = 3;

        switch (day)
        {
            case 1:
                WriteLine("Monday");
                break;
            case 2:
                WriteLine("Tuesday");
                break;
            case 3:
                WriteLine("Wednesday");
                break;
            case 4:
                WriteLine("Thursday");
                break;
            case 5:
                WriteLine("Friday");
                break;

            default:
                WriteLine("Invalid day");
                break;

        }

        // Expresions switch

        string daysMessage = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday", 
            _=> "Invalid day"
        };
        WriteLine(daysMessage);
    }
}