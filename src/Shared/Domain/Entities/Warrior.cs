using CharacterEngine;
using CharacterEngine.Interfaces;
using Utilities;

namespace Domain.Entities;

public class Warrior : Hero, ISpecialSkillUser, IPointsUser
{
    private int stamina;

    public int Stamina
    {
        get => stamina;
        set
        {
            if (value < 0)
                stamina = 0;
            else if (value > 20)
                stamina = 20; 
            else
                stamina = value;
        }
    }

    public Warrior(string? name) : base()
    {
        Name = name ?? "Unknow Warrior";
        Health += 50;        
        Armor += 10;     
        Weapon = "Great Sword";
        WeaponValue = 8;
        Stamina = 20;
    }

    public override void UseSpecialSkill()
    {
        PowerStrike();
    }

    private void PowerStrike()
    {
        if (Stamina >= 20)
        {
            Writing.Print($"{Name} uses Power Strike, dealing 25 damage and receiving a counter hit!\n");
        }
        else
        {
            Writing.Print($"{Name} doesn't have enough stamina to use Power Strike.\n");
        }
    }

    public int DealPowerStrikeDamage()
    {
        return 25;
    }

    public override void PointsAdd()
    {
        Stamina += 5;
        Stamina = (Stamina >= 20)? 20 : Stamina;
    }

    public override void ShowPoints()
    {
        Console.Write($"Stamina: {Stamina}");
    }
}
