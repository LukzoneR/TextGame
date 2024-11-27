using Utilities;
using CharacterEngine;
using CharacterEngine.Interfaces;

namespace Domain.Entities;

public class Mag : Hero, ISpecialSkillUser, IPointsUser
{
    public int Mana { get; set; }
    public int FireballDamage { get; set; }
    private int iceShieldTurns = 0;
    private int originalArmor;
    

    public Mag(string? name) : base()
    {
        Name = name ?? "Unknown Mage";
        Mana = 30;
        Damage += 5;
        Weapon = "Magic Staff";
        WeaponValue = 6;
        originalArmor = Armor;
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
            FireballDamage = 20;
            Writing.Print($"{Name} casts Fireball, dealing 20 damage!\n");
        }
        else
        {
            FireballDamage = 0;
            Writing.Print($"{Name} doesn't have enough mana to cast Fireball.\n");
        }
    }

    private void CastIceShield()
    {
        if (Mana >= 15)
        {
            Mana -= 15;
            iceShieldTurns = 4;
            Armor += 6;
            FireballDamage = 0;
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
                Armor = originalArmor;
                Writing.Print("The effect of Ice Shield has worn off.\n");
            }
        }
    }

    public override void PointsAdd()
    {
        Mana += 5;
        Mana = (Mana >= 30)? 30 : Mana;
    }

    public override void ShowPoints()
    {
        Console.Write($"Mana: {Mana}");
    }
}
