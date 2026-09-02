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

Console.WriteLine();
Console.WriteLine("Team Directory");
Console.WriteLine(new string('-', 50));

foreach (var member in team)
{
    Console.WriteLine($"Name: {member.Name}");
    Console.WriteLine($"Role: {member.Role}");
    Console.WriteLine($"Department: {member.Department}");
    Console.WriteLine($"Email: {member.Email}");
    Console.WriteLine(new string('-', 50));
}


