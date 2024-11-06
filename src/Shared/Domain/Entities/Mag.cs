
namespace Domain.Entities;

public class Mag : Hero
{
    public int Mana{ get; set; }

    public Mag(string? name) : base()
    {
        Name = name;    
        Mana = 100;
        Damage += 5;
        Weapon = "Magic Staff";
    }

    public override void UseSpecialSkill()
    {
        CastFireball();
    }

    public void CastFireball()
    {
        if(Mana >= 20)
        {
            Mana -= 20;
            Console.WriteLine($"{Name} throw a fireball and deal extra damage!");
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have enough magic points to throw fireball");
        }
    }

    public void CastIceShield()
    {
        if(Mana >= 15)
        {
            Mana -= 15;
            Armor += 10;
            Console.WriteLine($"{Name} throw ice shield and get 10 points of armor!");
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have enough magic points to throw ice shield");
        }
    }

}
