
namespace Methods;

public class FightRound
{
     public string? HeroName { get; set; }
    public string? EnemyName { get; set; }
    public int HeroHealth { get; set; }
    public int EnemyHealth { get; set; }
    public string? Action { get; set; }
    public int DamageTaken { get; set; }
    public int DamageDealt { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
