
namespace Methods;

public class Fight
{
    public static void Combat(bool random, Hero hero)
    {
        string? n = hero.Name;
        int h = hero.Health;
        int a = hero.Armor;

        if (random)
        {
            n = "Random Enemy";
            h = 50;
            a = 5;
        }

        while (hero.Health > 0)
        {
            Console.Clear();    
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|  (A)ttack       (D)efend |");
            Console.WriteLine("|         (P)ower          |");
            Console.WriteLine("|  (R)un          (H)eal   |");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine($"Potions: {hero.Potion} | Health: {hero.Health} \n");
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
                    Writing.Print($"{hero.Name} attacks the enemy!");
                    hero.Health -= 5;
                    Console.ReadKey();
                    break;

                case "d":
                case "defend":
                    Writing.Print($"{hero.Name} defends!");
                    hero.Health -= 2;
                    Console.ReadKey();
                    break;

                case "p":
                case "power":
                    Writing.Print($"{hero.Name} use a special attack!\n");
                    hero.UseSpecialSkill();
                    Console.ReadKey();
                    hero.Health -= 10;
                    break;

                case "r":
                case "run":
                    Writing.Print($"{hero.Name} runaway!");
                    Console.ReadKey();
                    return; 
                    
                case "h":
                case "heal":
                    if (hero.Potion > 0)
                    {
                        Writing.Print($"{hero.Name} use a potion!");
                        hero.Health += 20;
                        hero.Potion--;
                        Console.ReadKey();
                    }
                    else
                    {
                        Writing.Print("you don't have potions!");
                        Console.ReadKey();
                    }
                    break;

                default:
                    Writing.Print("Enter a valid option: (A)ttack, (D)efend, (P)ower, (R)un, (H)eal");
                    break;
            }

            if (hero.Health <= 0)
            {
                Writing.Print($"{hero.Name} was killed!");
                break;
            }
        }
    }
}