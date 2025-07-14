namespace AdvancedLinq
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }

    class Ability
    {
        public int CharacterId { get; set; }
        public string? Description { get; set; }
    }
    class Statistic
    {
        public int CharacterId { get; set; }
        public int Power { get; set; }
    }
    class Program
    {
        public static void AdvancedLINQ()
        {
            List<Character> characters =
            [
              new Character { Id = 1, Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" },
        new Character { Id = 4, Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new Character { Id = 5, Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
          ];

            List<Ability> abilities =
            [
              new Ability { CharacterId = 1, Description = "Sentido arácnido" },
        new Ability { CharacterId = 1, Description = "Trepar paredes" },
        new Ability { CharacterId = 2, Description = "Inteligencia y armadura de alta tecnología" },
        new Ability { CharacterId = 3, Description = "Super fuerza" },
        new Ability { CharacterId = 4, Description = "Reflejos aumentados" },
        new Ability { CharacterId = 5, Description = "Magia y hechicería" }
            ];
            List<Statistic> statistics =
            [
              new Statistic { CharacterId = 1, Power = 85 },
        new Statistic { CharacterId = 2, Power = 90 },
        new Statistic { CharacterId = 3, Power = 88 },
        new Statistic { CharacterId = 4, Power = 80 },
        new Statistic { CharacterId = 5, Power = 95 }
            ];

            var teamsQuery = from character in characters
                             group character by character.Team into team
                             select team;

            var teamsMethod = characters.GroupBy(character => character.Team);

            foreach (var team in teamsMethod)
            {
                // WriteLine($"👥 Team: {team.Key}");
                foreach (var character in team)
                {
                    // WriteLine($" - {character.Name}");
                }
            }


            // WriteLine("🦸‍♂️ Characters and their abilities:");

            var charactersWithAbilites = from character in characters
                                         join ability in abilities on character.Id equals ability.CharacterId
                                         select new { character.Alias, character.Name, ability.Description };

            var charactersWithAbilitesMethod = characters.Join(
                abilities,
                character => character.Id,
                ability => ability.CharacterId,
                (character, ability) => new { character.Alias, character.Name, ability.Description }
            );

            foreach (var character in charactersWithAbilitesMethod)
            {
                WriteLine($"{character.Alias} {character.Name} - Ability: {character.Description}");
            }

            int totalPower = statistics.Sum(statistic => statistic.Power);
            // WriteLine($"⚡ Total power of all characters: {totalPower}");

            var avengersPower = (from character in characters
                                 join statistic in statistics on character.Id equals statistic.CharacterId
                                 where character.Team == "Avengers"
                                 select statistic.Power).Average();

            var avengersPowerMethod = characters
            .Where(character => character.Team == "Avengers")
            .Join(
                statistics,
                character => character.Id,
                statistic => statistic.CharacterId,
                (character, statistic) => new { statistic.Power }
            )
            .Average(x => x.Power);

            WriteLine($"🛡️ Average power of the Avengers: {avengersPower:F2}");
            WriteLine($"🛡️ Average power method of the Avengers: {avengersPowerMethod:F2}");



            var abilitiesByCharacter = from character in characters
                                       join ability in abilities on character.Id equals ability.CharacterId
                                       group ability by character.Alias into groupAbilities
                                       select new { Character = groupAbilities.Key, Count = groupAbilities.Count() };

            var abilitiesByCharacterMethod = characters.Join(
                abilities,
                character => character.Id,
                ability => ability.CharacterId,
                (character, ability) => new { character.Alias, ability }
            )
            .GroupBy(x => x.Alias)
            .Select(groupAbilities => new { Character = groupAbilities.Key, Count = groupAbilities.Count() });

            // WriteLine("📝 Number of abilities per character:");
            foreach (var character in abilitiesByCharacterMethod)
            {
                WriteLine($"{character.Character}: {character.Count} abilities");
            }
        }
    }
}