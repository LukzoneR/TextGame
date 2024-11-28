using System.Text.Json;

namespace Methods;
public class StatsSaver
{
    static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName ?? "";
    static string filesDirectory = Path.Combine(projectDirectory, "Files");
    public List<FightRound> fightLog = new List<FightRound>();

    public void Save()
    {
        try
        {
            if (!Directory.Exists(filesDirectory))
            {
                Directory.CreateDirectory(filesDirectory);
            }

            string filePath = Path.Combine(filesDirectory, "fight_log.json");

            string json = JsonSerializer.Serialize(fightLog, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);

            Console.WriteLine($"Log walki zapisany do: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas zapisywania logu walki: {ex.Message}");
        }
        Console.ReadKey();
    }
}
