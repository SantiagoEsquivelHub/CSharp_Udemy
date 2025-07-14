// LINQ = Language Integrated Query
partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // Query Sintax
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        // Method Sintax
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }

        // Simples Queries
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
          new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
          new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
          new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
          new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
         };

        // WriteLine("Characters that belongs to Avengers");

        var avengersQuery = from character in characters
                            where character.Team == "Avengers"
                            select $"{character.Alias} - {character.Name}";

        var avengersMethod = characters.Where(character => character.Team == "Avengers");
        foreach (var character in avengersMethod)
        {
            // WriteLine($"{character.Alias} - {character.Name}");
        }

        // WriteLine("Capital letters names");

        var uppercaseNamesQuery = from character in characters
                                  select character?.Name?.ToUpper();

        var uppercaseNamesMethod = characters.Select(character => character?.Name?.ToUpper());

        foreach (var name in uppercaseNamesMethod)
        {
            //   WriteLine(name);
        }

        // WriteLine("Sort names in descending order: ");

        var sortedQuery = from character in characters
                          orderby character.Name descending
                          select character.Name;

        var sortedMethod = characters.OrderByDescending(character => character.Name);

        foreach (var character in sortedMethod)
        {
            WriteLine(character.Name);
        }

        // First three characters

        var firstThreeQuery = (from character in characters select character).Take(3);

        var firstThreeMethod = characters.Take(3);

        foreach (var character in firstThreeMethod)
        {
            WriteLine(character.Name);
        }
    }

    class MarvelCharacter
    {
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
}