using Utilities;

namespace Domain.Entities;

public class Warrior : Hero
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

    public void PowerStrike()
    {
        if(Stamina >= 20){
            Writing.Print($"{Name} make power strike and deal huge damage!");
            Stamina -= 20;
        }
        else
        {
            Writing.Print("You don't have enough stamina to do Power Strike");
        }
    }

    public void RegenerateStamina(int amount)
    {
        Stamina += amount;
    }

}
