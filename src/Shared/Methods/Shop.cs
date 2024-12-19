using Domain.Entities;
using Utilities;

namespace Methods;
public class Shop
{
    public static void LoadShop(Hero hero, bool isItem = false)
    {
        RunShop(hero, isItem);
    }

    public static void RunShop(Hero hero, bool isItem = false)
    {
        EnemyPictures enemyPictures = new EnemyPictures();
        int potionCost = 200;

        Console.Clear();
        Console.Write(enemyPictures.Mike);
        Console.WriteLine();
        Writing.Print("Look at my commodity\n\n\n");
        Console.ReadKey();

        while (true)
        {
            int armorCost = 100 + 10 * hero.Armor;
            int weaponCost = 100 + 10 * hero.WeaponValue;

            RenderShopMenu(armorCost, weaponCost, potionCost, isItem);

            hero.DisplayStats();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Choose an action:");
            Console.Write(" > ");

            string? input = Console.ReadLine()?.ToLower().Trim();
            if (!ProcessInput(input, hero, potionCost, armorCost, weaponCost, isItem))
                break; 
        }
    }

    private static void RenderShopMenu(int armorCost, int weaponCost, int potionCost, bool isItem)
    {
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

        if (isItem)
        {
            Console.WriteLine("|                    ");
            Console.WriteLine("|    (T)orch: $0   ");
        }

        Console.WriteLine("|                    ");
        Console.WriteLine("|      (E)xit        ");
        Console.WriteLine("|                    ");
        Console.WriteLine("----------------------");
    }

    private static bool ProcessInput(string? input, Hero hero, int potionCost, int armorCost, int weaponCost, bool isItem)
    {
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
                if (isItem)
                {
                    BuyAttempt("torch", 0, hero);
                    Writing.Print("No problem " + hero.Name);
                    return false;
                }
                else
                {
                    Writing.Print("Invalid option. No torch available!");
                }
                break;
            case "e":
            case "exit":
                if (isItem)
                {
                    Writing.Print("You have to take torch first");
                }
                else
                {
                    return false;
                }
                break;
            default:
                Writing.Print("Enter a valid option: (A)rmor, (W)eapon, (P)otion" + (isItem ? ", (T)orch" : "") + "\n");
                Console.ReadKey();
                break;
        }
        return true;
    }

    public static void BuyAttempt(string item, int price, Hero hero)
    {
        if (hero.Gold >= price)
        {
            if (item == "potion")
                hero.Potion++;
            else if (item == "armor")
                hero.Armor += 2;
            else if (item == "weapon")
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
