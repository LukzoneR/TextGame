using CharacterEngine;
using CharacterEngine.Interfaces;
namespace Domain.Entities;
public class Hero : ICharacter, ISpecialSkillUser, IStatsDisplay, IPointsUser
{
    public string? Name{ get; set; }
    public int Health{ get; set; }
    public int Damage{ get; set; }
    public int Gold{ get; set; }
    public int Armor{ get; set; }
    public string? Weapon{ get; set; }
    public int WeaponValue{ get; set; }
    public int Potion{ get; set; }

    public Hero()
    {
        Health = 100;
        Damage = 5;
        Gold = 1000;
        Armor = 5;
        Weapon = "Basic Sword";
        WeaponValue = 5;
        Potion = 3;
    }

    public virtual void UseSpecialSkill()
    {
        Console.WriteLine($"{Name} use special power!");
    }

    public virtual void ShowPoints()
    {
        Console.Write(" Points ");
    }

    public virtual void PointsAdd()
    {
        Console.Write("Gain Points");
    }

    public virtual void  DisplayStats()
    {
        Console.WriteLine($"            {Name} Stats           ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("|                                  ");
        Console.WriteLine($"|            Gold: ${Gold}         ");
        Console.WriteLine("|                                  ");
        Console.WriteLine($"|          Weapon: {Weapon}        ");
        Console.WriteLine("|                                  ");
        Console.WriteLine($"|    WeaponDamage: {WeaponValue}   ");
        Console.WriteLine("|                                  ");
        Console.WriteLine($"|           Armor: {Armor}         ");
        Console.WriteLine("|                                  ");
        Console.WriteLine("------------------------------------");
    }

}
