using Domain.Entities;
using Utilities;
namespace Methods;

public class Fight
{
    static Random random = new Random();
    public static void Combat(bool rand, Hero hero, string name, int health, int power)
    {
        string? enemyName = "";
        int enemyHealth = 0;
        int enemyPower = 0;

        int damage = 0;
        int attack = 0;

        if (rand)
        {
            
        }
        else
        {
            enemyName = name;
            enemyHealth = health;
            enemyPower = power;
        }

        while (hero.Health > 0 && enemyHealth >= 0)
        {
            Console.Clear();
            Console.WriteLine($"Enemy name: {enemyName}");
            Console.WriteLine($"Enemy Health: {enemyHealth} | Enemy Power: {enemyPower}");
            Console.WriteLine("");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|  (A)ttack       (D)efend |");
            Console.WriteLine("|         (P)ower          |");
            Console.WriteLine("|  (R)un          (H)eal   |");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine($"Potions: {hero.Potion} | Health: {hero.Health} | Armor: {hero.Armor}");
            Writing.Print("Choose an action: \n");

            string? input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Writing.Print("Please enter a valid action.");
                continue;
            }

            switch (input)
            {
                case "a":
                case "attack":
                    Writing.Print($"{hero.Name} attacks the enemy!\n");
                    damage = random.Next(hero.Armor, enemyPower+1) - hero.Armor - random.Next(1,5);
                    damage = (damage < 0)? 0 : damage;
                    attack = random.Next(0, hero.WeaponValue) + random.Next(2, hero.Damage) + random.Next(1, 4);
                    hero.Health -= damage;
                    enemyHealth -= attack;
                    Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    break;

                case "d":
                case "defend":
                    Writing.Print($"{hero.Name} defends!\n");
                    damage = (enemyPower/random.Next(2,5)) - hero.Armor;
                    damage = (damage < 0)? 0 : damage;
                    attack = random.Next(0, hero.WeaponValue)/2 + random.Next(2, hero.Damage)/2;
                    hero.Health -= damage;
                    enemyHealth -= attack;
                    Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    break;

                case "p":
                case "power":
                    Writing.Print($"{hero.Name} use a special attack!\n");
                    hero.UseSpecialSkill();
                    hero.Health -= 10;
                    break;

                case "r":
                case "run":
                    if(random.Next(0,2) == 0)
                    {
                        Writing.Print($"{hero.Name} runaway!\n");
                        Console.ReadKey();  
                        return;
                    }
                    else
                    {
                        Writing.Print($"{enemyName} unfortunately caught you while you've been trying to escape.\n");
                        damage = enemyPower - hero.Armor  - random.Next(1,5);
                        damage = (damage < 0)? 0 : damage;
                        hero.Health -= damage;
                        Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                        break;
                    } 
                    
                case "h":
                case "heal":
                    if (hero.Potion > 0)
                    {
                        Writing.Print($"{hero.Name} use a potion!\n");
                        hero.Health += 20;
                        hero.Potion--;
                        Writing.Print($"{hero.Name} got {20} health points.\n");
                    }
                    else
                    {
                        Writing.Print("you don't have any potions! That mistake will cost you some bruises.\n");
                        damage = enemyPower - hero.Armor  - random.Next(1,5);
                        damage = (damage < 0)? 0 : damage;
                        hero.Health -= damage;
                        Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    }
                    break;

                default:
                    Writing.Print("Enter a valid option: (A)ttack, (D)efend, (P)ower, (R)un, (H)eal\n");
                    break;
            }
            Console.ReadKey();

            if (hero.Health <= 0)
            {
                Writing.Print($"{hero.Name} was killed!");
                break;
            }
        }
    }
}