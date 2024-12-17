
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
        PuzzleGame puzzle = new PuzzleGame();
        StoryPrint storyPrint= new StoryPrint();
        Strings strings= new Strings();
        Intro intro= new Intro();
        intro.ArtPrint();
        
        Writing.Print(strings.text[0]);
        Console.Write(" > ");
        hero.Name = Console.ReadLine();

        if(hero.Name == "")
        {
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
        Console.Clear();
        storyPrint.Write(strings.text[7]);
        storyPrint.Write(strings.text[8]);
        Console.ForegroundColor = ConsoleColor.Red;
        storyPrint.Write(strings.text[9]);
        Console.ResetColor();
        storyPrint.Write(strings.text[10]);

        Writing.Print(strings.text[11]);
        Console.Write(" > ");
        string? choice2;
        bool loopStop2 = false;
        do
        {
            choice2 = Console.ReadLine()?.Trim();

            switch(choice2)
            {
                case "1":
                    storyPrint.Write(strings.text[12]);
                    loopStop2 = true;
                    Fight.Combat(false, hero, "Orc", 40, 20);
                    break;
                case "2":
                    storyPrint.Write(strings.text[13]);
                    storyPrint.Write(strings.text[14]);
                    Fight.Combat(true, hero);
                    loopStop2 = true;
                    break;
                default:
                    Writing.Print("Choose one of two below\n");
                    Console.Write(" > ");
                    break;
            }
        }while(!loopStop2);
        Console.Clear();
        storyPrint.Write(strings.text[15]);
        Shop.LoadShop(hero);
        Console.Clear();

        storyPrint.Write(strings.text[16]);
        storyPrint.Write(strings.text[17]);
        puzzle.Play();
        Console.Clear();
        storyPrint.Write(strings.text[18]);
        storyPrint.Write(strings.text[19]);
        Shop.LoadShop(hero, true);
        Console.Clear();
        storyPrint.Write(strings.text[20]);
        storyPrint.Write(strings.text[21]);
        Console.Clear();
        Writing.Print(strings.text[22]);
        Console.Write(" > ");
        string? choice3;
        bool loopStop3 = false;
        do
        {
            choice3 = Console.ReadLine()?.Trim();

            switch(choice3)
            {
                case "1":
                    storyPrint.Write(strings.text[23]);
                    storyPrint.Write(strings.text[24]);
                    Fight.Combat(true, hero);
                    Fight.Combat(true, hero);
                    storyPrint.Write(strings.text[25]);
                    storyPrint.Write(strings.text[26]);
                    storyPrint.Write(strings.text[27]);
                    hero.Gold += 200;
                    Shop.LoadShop(hero);
                    break;
                case "2":
                    storyPrint.Write(strings.text[28]);
                    storyPrint.Write(strings.text[29]);
                    storyPrint.Write(strings.text[30]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    storyPrint.Write(strings.text[31]);
                    Console.ResetColor();
                    Console.Clear();
                    Console.Write(" > ");
                    string? choice4;
                    choice4 = Console.ReadLine()?.Trim();
                    
                    if(choice4 != hero.Name) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        storyPrint.Write(strings.text[33]);
                        Console.ResetColor();
                        Fight.Combat(false, hero, "Skeleton", 35, 30);
                    }else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        storyPrint.Write(strings.text[32]);
                        Console.ResetColor();
                        hero.Gold += 50;
                    }
                    break;
                default:
                    Writing.Print("Choose one of two below\n");
                    Console.Write(" > ");
                    break;
            }
        }while(!loopStop3);


        
        Fight.Combat(false, hero, "Dragon", 100, 40);
        Shop.LoadShop(hero);
        Fight.Combat(true, hero);
        
    }
}