
namespace ClassLibrary1;

public class Fight
{
    private Hero _hero;

    public Fight(Hero hero)
    {
        _hero = hero;
    }
    public static void Combat(bool random, string name, int power, int health, int armor)
    {
        string n = "";
        int p = 0;
        int h = 0;
        int a = 0;
        if(random)
        {

        }
        else
        {
            n = name;
            p = power;
            h = health;
            a = armor;
        }

        while(h > 0)
        {
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|  (A)ttack       (D)efend |");
            Console.WriteLine("|         (P)ower          |");
            Console.WriteLine("|  (R)un          (H)eal   |");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine(" Potions: " + _hero.Potion);
        }

    }
}
