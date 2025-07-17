using System.Text.Json;

namespace ManageJsonFile
{
  class Character
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
  }
  partial class Program
  {
    public static void ManageJsonFile()
    {
      string filePath = "./05-Files/characters.json";
      List<Character> characters =
      [
        new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias
        = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
      ];

      var charactersJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
      File.WriteAllText(filePath, charactersJson);

      var charactersFromFile = File.ReadAllText(filePath);
      var characterList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile)!;

      foreach (var character in characterList)
      {
        WriteLine($"Id: {character.Id}, Name: {character.Name}, Alias: {character.Alias}");
      }
    }
  }
}