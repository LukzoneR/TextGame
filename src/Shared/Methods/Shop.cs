
using Domain.Entities;
using Utilities;

namespace Methods;
public class Shop
{
    public static void LoadShop(Hero hero, bool isItem = false)
    {

        if(isItem) RunShop(hero, true);
        else RunShop(hero);
        
    }

    public static void RunShop(Hero hero, bool isItem = false)
    {
        EnemyPictures enemyPictures= new EnemyPictures();
        int potionCost = 200;
        int armorCost;
        int weaponCost;

        Console.Clear();
        Console.Write(enemyPictures.Mike);
        Console.WriteLine();
        Writing.Print("Look at my commodity\n\n\n");
        Console.ReadKey();

        if(isItem)
        {
            while (true)
            {
                armorCost = 100 + 10 * hero.Armor;
                weaponCost = 100 + 10 * hero.WeaponValue;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("         Shop         ");
                Console.WriteLine("----------------------");
                Console.WriteLine("|                    ");
                Console.WriteLine("|     (A)rmor: $" + armorCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|    (W)eapon: $" + weaponCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|    (P)otion: $" + potionCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|    (T)orch: $0   ");
                Console.WriteLine("|                    ");
                Console.WriteLine("|      (E)xit        ");
                Console.WriteLine("|                    ");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                hero.DisplayStats();
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Choose an action:");
                Console.Write(" > ");

                string? input = Console.ReadLine()?.ToLower().Trim();
                switch (input)
                {
                    case "p":
                    case "potion":
                        BuyAttempt("potion", potionCost, hero);
                        break;
                    case "a":
                    case "armor":
                        BuyAttempt("armor", armorCost, hero);
                        break;
                    case "w":
                    case "weapon":
                        BuyAttempt("weapon", weaponCost, hero);
                        break;
                    case "t":
                    case "torch":
                        BuyAttempt("torch", 0, hero);
                        Writing.Print("No problem " + hero.Name);
                        return;
                    case "e":
                    case "exit":
                        Writing.Print("You have to take torch first");
                        break;
                    default:
                        Writing.Print("Enter a valid option: (A)rmor, (W)eapon, (P)otion, (T)orch\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
        else
        {
            while (true)
            {
                armorCost = 100 + 10 * hero.Armor;
                weaponCost = 100 + 10 * hero.WeaponValue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("         Shop         ");
                Console.WriteLine("----------------------");
                Console.WriteLine("|                    ");
                Console.WriteLine("|     (A)rmor: $" + armorCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|    (W)eapon: $" + weaponCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|    (P)otion: $" + potionCost);
                Console.WriteLine("|                    ");
                Console.WriteLine("|      (E)xit        ");
                Console.WriteLine("|                    ");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                hero.DisplayStats();
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Choose an action:");
                Console.Write(" > ");

                string? input = Console.ReadLine()?.ToLower().Trim();
                switch (input)
                {
                    case "p":
                    case "potion":
                        BuyAttempt("potion", potionCost, hero);
                        break;
                    case "a":
                    case "armor":
                        BuyAttempt("armor", armorCost, hero);
                        break;
                    case "w":
                    case "weapon":
                        BuyAttempt("weapon", weaponCost, hero);
                        break;
                    case "e":
                    case "exit":
                        return;
                    default:
                        Writing.Print("Enter a valid option: (A)rmor, (W)eapon, (P)otion\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public static void BuyAttempt(string item, int price, Hero hero)
    {
        if(hero.Gold >= price)
        {
            if(item == "potion")
                hero.Potion ++;
            else if (item == "armor")
                hero.Armor += 2;
            else if(item == "weapon")
                hero.WeaponValue += 2;

            hero.Gold -= price;
        }
        else
        {
            Writing.Print("You don't have enough money!");
            Console.ReadKey();
        }
    }
}
