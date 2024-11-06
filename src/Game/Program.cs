
using ClassLibrary1;
using Domain.Entities;

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
        Intro intro= new Intro();
        intro.ArtPrint();
        
        Writing.Print("Welcome to dark forest, please enter your hero name:\n");
        Console.Write(" > ");
        hero.Name = Console.ReadLine();

        if(hero.Name == ""){
            Writing.Print("Don't play with me. Enter your name!:\n");
            Console.Write(" > ");
            hero.Name = Console.ReadLine();
            if(hero.Name == "")
            {
                Writing.Print("Alright your name is Puff Diddy\n");
                hero.Name = "Puff Diddy";
            }
        }
  
        Writing.Print("Let's begin " + hero.Name);
        Writing.Print(" . . . \n", 200);
        Console.ReadKey();
        Console.Clear();
        
        Writing.Print("In the distant future, humanity has not survived. Cataclysms, wars and magic that returned after centuries of absence led the world to collapse.\nIn the ruins of ancient civilizations,\na handful of survivors fight for survival in a world dominated by demonic beings and corrupt, dark deities.");
        Console.ReadKey();
        Console.Clear();

        Writing.Print("Your mission is to survive in this harsh world, gather strength and unite the remnants of humanity to face the final threat.");
        Console.ReadKey();
        Console.Clear();

        Writing.Print("You are a mysterious figure who woke up with no memories of his past, in the heart of a dark forest full of beasts and mysterious ruins.\nOver time, you discover that your origins are crucial to the fate of the world.");
        Console.ReadKey();
        Console.Clear();



        Writing.Print("Now it is time to choose your way.\nChoose who are you want to be:\n(1) Mag\n(2) Warrior\n");
        Console.Write(" > ");

        string? choice;
        bool loopStop = false;
        do
        {
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    hero = new Mag(hero.Name);
                    Writing.Print($"{hero.Name} has been chosen as Mag.\n");
                    Writing.Print("Your skills are fireball cast and ice shield");
                    loopStop = true;
                    break;
                case "2":
                    hero = new Warrior(hero.Name);
                    Writing.Print($"{hero.Name} has been chosen as Warrior.\n");
                    Writing.Print("Your skill is power strike");
                    loopStop = true;
                    break;
                default:
                    Writing.Print("Choose one of two below\n");
                    Console.Write(" > ");
                    break;
            }
        }while(!loopStop);
        
    }
}