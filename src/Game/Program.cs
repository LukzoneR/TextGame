
using Methods;
using Domain.Entities;
using Utilities;

namespace app;

class Program
{
    public static Hero hero = new Hero();
    static void Main(string[] arg)
    {
        Start();            
    }
    static void Start()
    {
        StoryPrint storyPrint= new StoryPrint();
        Strings strings= new Strings();
        Intro intro= new Intro();
        intro.ArtPrint();
        
        Writing.Print(strings.text[0]);
        Console.Write(" > ");
        hero.Name = Console.ReadLine();

        if(hero.Name == ""){
            Writing.Print(strings.text[1]);
            Console.Write(" > ");
            hero.Name = Console.ReadLine();
            if(hero.Name == "")
            {
                Writing.Print(strings.text[2]);
                hero.Name = "Marian";
            }
        }
  
        Writing.Print("Let's begin " + hero.Name);
        Writing.Print(" . . . \n", 200);
        Console.ReadKey();
        Console.Clear();

        storyPrint.Write(strings.text[3]);
        storyPrint.Write(strings.text[4]);
        storyPrint.Write(strings.text[5]);

        Writing.Print(strings.text[6]);
        Console.Write(" > ");

        string? choice;
        bool loopStop = false;
        do
        {
            choice = Console.ReadLine()?.Trim();

            switch(choice)
            {
                case "1":
                    hero = new Mag(hero.Name);
                    Writing.Print($"{hero.Name} has been chosen as Mage.\n");
                    Writing.Print("Your skills are fireball cast and ice shield");
                    Console.ReadKey();
                    loopStop = true;
                    break;
                case "2":
                    hero = new Warrior(hero.Name);
                    Writing.Print($"{hero.Name} has been chosen as Warrior.\n");
                    Writing.Print("Your skill is power strike");
                    Console.ReadKey();
                    loopStop = true;
                    break;
                default:
                    Writing.Print("Choose one of two below\n");
                    Console.Write(" > ");
                    break;
            }
        }while(!loopStop);

        Fight.Combat(false, hero, "Dragon", 100, 40);
        Shop.LoadShop(hero);
        Fight.Combat(true, hero);
        
    }
}