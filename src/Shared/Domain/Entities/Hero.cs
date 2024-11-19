using CharacterEngine;
namespace Domain.Entities;
public class Hero : ICharacter, ISpecialSkillUser, IStatsDisplay
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
        Gold = 0;
        Armor = 5;
        Weapon = "Basic Sword";
        WeaponValue = 5;
        Potion = 3;
    }

    public virtual void UseSpecialSkill()
    {
        Console.WriteLine($"{Name} use special power!");
    }

    public virtual void  DisplayStats()
    {
        Console.WriteLine($"Name: {Name}, Health: {Health}, Damage: {Damage}, Gold: {Gold}, Armor: {Armor}, Weapon: {Weapon}");
    }

}
