
namespace Domain.Entities;

public class Warrior : Hero
{
        public Warrior(string? name) : base()
    {
        Name = name;
        Health += 50;        
        Armor += 10;     
        Weapon = "Great Sword";
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
