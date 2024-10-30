
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
        Console.WriteLine($"{Name} wykonuje Power Strike, zadając ogromne obrażenia fizyczne!");
    }

    public void ShieldBlock()
    {
        Console.WriteLine($"{Name} używa Shield Block, zmniejszając obrażenia od następnego ataku.");
    }
    }
