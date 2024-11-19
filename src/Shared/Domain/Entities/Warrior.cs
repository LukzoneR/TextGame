
namespace Domain.Entities;

public class Warrior : Hero
{
        public Warrior(string? name) : base()
    {
        Name = name ?? "Unknow Warrior";
        Health += 50;        
        Armor += 10;     
        Weapon = "Great Sword";
        WeaponValue = 8;
    }

    public override void UseSpecialSkill()
    {
        PowerStrike();
    }

    public void PowerStrike()
    {
        Console.WriteLine($"{Name} make power strike and deal huge damage!");
    }

}
