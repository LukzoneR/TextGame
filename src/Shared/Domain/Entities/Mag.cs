using Utilities;
using CharacterEngine;

namespace Domain.Entities;

public class Mag : Hero, IManaUser
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
                CastSpell("Fireball");
                break;

            case "i":
            case "iceshield":
                CastSpell("IceShield");
                break;

            default:
                Console.WriteLine("Invalid choice. Please choose either (F)ireball or (I)ceShield.");
                break;
        }
    }

    public void CastSpell(string spellName)
    {
        if (spellName == "Fireball" && Mana >= 20)
        {
            Mana -= 20;
            Writing.Print($"{Name} casts Fireball, dealing extra damage!");
        }
        else if (spellName == "IceShield" && Mana >= 15)
        {
            Mana -= 15;
            Armor += 10;
            Writing.Print($"{Name} uses Ice Shield, gaining 10 armor points!");
        }
        else
        {
            Writing.Print($"{Name} doesn't have enough mana to cast {spellName}.");
        }
    }

}
