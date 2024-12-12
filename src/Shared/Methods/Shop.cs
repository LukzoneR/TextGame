
using Domain.Entities;
using Utilities;

namespace Methods;
public class Shop
{
    public static void LoadShop(Hero hero)
    {
        RunShop(hero);
    }

    public static void RunShop(Hero hero)
    {
        EnemyPictures enemyPictures= new EnemyPictures();
        int potionCost = 200;
        int armorCost;
        int weaponCost;

        while (true)
        {
            armorCost = 100 + 10 * hero.Armor;
            weaponCost = 100 + 10 * hero.WeaponValue;

            Console.Clear();
            Console.Write(enemyPictures.Dealer);
            Console.WriteLine();
            Writing.Print("Look at my commodity\n\n\n");
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

    public static void BuyAttempt(string item, int price, Hero hero)
    {
        if(hero.Gold >= price)
        {
            if(item == "potion")
            {
                hero.Potion ++;
            }
            else if (item == "armor")
            {
                hero.Armor += 2;
            }
            else if(item == "weapon")
            {
                hero.WeaponValue += 2;
            }

            hero.Gold -= price;
        }
        else
        {
            Writing.Print("You don't have enough money!");
            Console.ReadKey();
        }
    }
}
