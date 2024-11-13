
namespace Domain.Entities;

public class Mag : Hero
{
    public int Mana { get; set; }

    public Mag(string? name) : base()
    {
        Name = name ?? "Unknown Mage";
        Mana = 100;
        Damage += 5;
        Weapon = "Magic Staff";
    }

    public override void UseSpecialSkill()
    {
        Console.WriteLine("Choose a spell: (F)ireball or (I)ceShield");
        Console.Write(" > ");
        
        string? input = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Please enter a valid action.");
            return;
        }

        switch (input)
        {
            case "f":
            case "fireball":
                CastFireball();
                break;

            case "i":
            case "iceshield":
                CastIceShield();
                break;

            default:
                Console.WriteLine("Invalid choice. Please choose either (F)ireball or (I)ceShield.");
                break;
        }
    }

    public void CastFireball()
    {
        if (Mana >= 20)
        {
            Mana -= 20;
            Console.WriteLine($"{Name} throws a fireball, dealing extra damage!");
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have enough mana to cast Fireball.");
        }
    }

    public void CastIceShield()
    {
        if (Mana >= 15)
        {
            Mana -= 15;
            Armor += 10;
            Console.WriteLine($"{Name} uses Ice Shield, gaining 10 points of armor!");
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have enough mana to cast Ice Shield.");
        }
    }
}