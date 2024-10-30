
namespace Domain.Entities;

public class Hero
{
    public string? Name{ get; set; }
    public int Health{ get; set; }
    public int Damage{ get; set; }
    public int Gold{ get; set; }
    public int Armor{ get; set; }
    public string? Weapon{ get; set; }

    public Hero()
    {
        Health = 100;
        Damage = 10;
        Gold = 0;
        Armor = 5;
        Weapon = "Basic Sword";
    }

        public virtual void UseSpecialSkill()
    {
        Console.WriteLine($"{Name} use special power!");
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}, Health: {Health}, Damage: {Damage}, Gold: {Gold}, Armor: {Armor}, Weapon: {Weapon}");
    }

}
