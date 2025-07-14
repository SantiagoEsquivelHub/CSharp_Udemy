using System.Globalization;

partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
            return "Positive";
        else if (number < 0)
            return "Negative";
        else
            return "Zero";
    }

    static void Functions()
    {

        double area = CalculateArea(4.5, 2.23);
        WriteLine($"Area: {area}");

        string evaluatedNumber = EvaluateNumber(-45);
        WriteLine($"evaluatedNumber: {evaluatedNumber}");

    }
}