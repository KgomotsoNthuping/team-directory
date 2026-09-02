using System.Text.Json;
using TeamDirectory;

var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "team_data.json");

var json = File.ReadAllText(dataPath);

var team = JsonSerializer.Deserialize<List<TeamMember>>(
    json,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    }
) ?? new List<TeamMember>();

Console.WriteLine($"Loaded {team_data.Count} team members.");
