partial class Program
{
    static void ListDictonary()
    {
        //List
        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
        names.Add("Lucia");
        Console.WriteLine($"Names total: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");

        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"Ana is on the list? {isPresent}");

        // Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {1, "Elena"}
        };

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

    }
}