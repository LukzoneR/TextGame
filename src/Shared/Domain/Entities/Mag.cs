
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
            Console.WriteLine($"{Name} rzuca Fireball, zadając magiczne obrażenia!");
        }
        else
        {
            Console.WriteLine($"{Name} nie ma wystarczającej ilości many na Fireball.");
        }
    }

    public void CastIceShield()
    {
        if(Mana >= 15)
        {
            Mana -= 15;
            Console.WriteLine($"{Name} rzuca Ice Shield, redukując obrażenia przez krótki czas.");
        }
        else
        {
            Console.WriteLine($"{Name} nie ma wystarczającej ilości many na Ice Shield.");
        }
    }
}
