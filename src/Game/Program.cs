
using ClassLibrary1;
using Domain.Entities;

namespace app;

class Program
{
    static void Writing(string text, int time = 60)
    {
        bool isStop = false;
        string writtenText = "";

        foreach (char c in text)
        {
            if(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                isStop = true;
                break;
            }

            Console.Write(c);
            writtenText += c;
            Thread.Sleep(time);         
        }

        if(isStop)
        {
            string remainingText = text.Substring(writtenText.Length);
            Console.Write(remainingText);
        }
    }
    


    static void Main(string[] arg)
    {
        Start();            
    }



    static void Start()
    {

        Intro intro= new Intro();
        Hero hero= new Hero();

        intro.ArtPrint();
        
        Writing("Welcome to dark forest, please enter your hero name:\n");
        Console.Write(" > ");
        hero.Name = Console.ReadLine();

        if(hero.Name == ""){
            Writing("Don't play with me. Enter your name!:\n");
            Console.Write(" > ");
            hero.Name = Console.ReadLine();
            if(hero.Name == "")
            {
                Writing("Alright your name is Puff Diddy\n");
                hero.Name = "Puff Diddy";
            }
        }
  
        Writing("Let's begin " + hero.Name);
        Writing(" . . . \n", 200);
        Console.ReadKey();
        Console.Clear();
        
        Writing("In the distant future, humanity has not survived. Cataclysms, wars and magic that returned after centuries of absence led the world to collapse.\nIn the ruins of ancient civilizations,\na handful of survivors fight for survival in a world dominated by demonic beings and corrupt, dark deities.");
        Console.ReadKey();
        Console.Clear();

        Writing("Your mission is to survive in this harsh world, gather strength and unite the remnants of humanity to face the final threat.");
        Console.ReadKey();
        Console.Clear();

        Writing("You are a mysterious figure who woke up with no memories of his past, in the heart of a dark forest full of beasts and mysterious ruins.\nOver time, you discover that your origins are crucial to the fate of the world.");
        Console.ReadKey();
        Console.Clear();



        Writing("Now it is time to choose your way.\nChoose who are you want to be:\n(1) Mag\n(2) Warrior\n");
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
                    Writing($"{hero.Name} has been chosen as Mag.");
                    loopStop = true;
                    break;
                case "2":
                    hero = new Warrior(hero.Name);
                    Writing($"{hero.Name} has been chosen as Warrior.");
                    loopStop = true;
                    break;
                default:
                    Writing("Choose one of two below\n");
                    Console.Write(" > ");
                    break;
            }
        }while(!loopStop);
        
    }
}