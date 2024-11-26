using Utilities;
using CharacterEngine;

namespace Domain.Entities;

public class Mag : Hero, ISpecialSkillUser
{
    public int Mana { get; set; }
    public int FireballDamage { get; set; }
    private int iceShieldTurns = 0; // Licznik tur dla IceShield
    private int originalArmor;
    

    public Mag(string? name) : base()
    {
        Name = name ?? "Unknown Mage";
        Mana = 100;
        Damage += 5;
        Weapon = "Magic Staff";
        WeaponValue = 6;
        originalArmor = Armor; // Zapamiętanie pierwotnego pancerza

    }

    public override void UseSpecialSkill()
    {
        Writing.Print("Choose a spell: (F)ireball or (I)ceShield\n");
        Console.Write(" > ");
        
        string? input = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(input))
        {
            Writing.Print("Please enter a valid action.");
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

    private void CastFireball()
    {
        if (Mana >= 20)
        {
            Mana -= 20;
            FireballDamage = DealFireballDamage();
            Writing.Print($"{Name} casts Fireball, dealing 20 damage!\n");
        }
        else
        {
            Writing.Print($"{Name} doesn't have enough mana to cast Fireball.\n");
        }
    }

    private void CastIceShield()
    {
        if (Mana >= 15)
        {
            Mana -= 15;
            iceShieldTurns = 4; // Efekt trwa przez 3 rundy
            Armor += 6; // Zwiększenie pancerza
            Writing.Print($"{Name} casts Ice Shield, gaining 6 armor for 3 turns!\n");
        }
        else
        {
            Writing.Print($"{Name} doesn't have enough mana to cast Ice Shield.\n");
        }
    }

    public void ProcessTurnEffects()
    {
        if (iceShieldTurns > 0)
        {
            iceShieldTurns--;
            if (iceShieldTurns == 0)
            {
                Armor = originalArmor; // Przywrócenie pierwotnego pancerza
                Writing.Print("The effect of Ice Shield has worn off.\n");
            }
        }
    }

    public int DealFireballDamage()
    {
        return 20; // Fireball zadaje 20 obrażeń
    }
}
