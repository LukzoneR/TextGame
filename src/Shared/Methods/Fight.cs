using Domain.Entities;
using Utilities;
namespace Methods;

public class Fight
{
    static Random random = new Random();
    public static void Combat(bool rand, Hero hero, string name="", int health=0, int power=0)
    {
        StatsSaver statsSaver = new StatsSaver();

        //enemy 
        EnemyPictures enemyPictures= new EnemyPictures();
        string? enemyName = "";
        int enemyHealth = 0;
        int enemyPower = 0;

        //player
        int damage = 0;
        int attack = 0;


        if (rand)
        {
            Enemy enemy = new Enemy();
            enemy.RandomStatsGenerator();
            enemyName = enemy.Name;
            enemyHealth = enemy.Health;
            enemyPower = enemy.Power;
        }
        else
        {
            enemyName = name;
            enemyHealth = health;
            enemyPower = power;
        }

        while (hero.Health > 0 && enemyHealth > 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            switch (enemyName)
            {
                case "Goblin":
                    Console.Write(enemyPictures.Goblin);
                    break;
                case "Nazgul":
                    Console.Write(enemyPictures.Nazgul);
                    break;
                case "Ghoul":
                    Console.Write(enemyPictures.Ghoul);
                    break;
                case "Orc":
                    Console.Write(enemyPictures.Orc);
                    break;
                case "Skeleton":
                    Console.Write(enemyPictures.Skeleton);
                    break;
                case "Dragon":
                    Console.Write(enemyPictures.Dragon);
                    break;    
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"Enemy name: {enemyName}");
            Console.WriteLine($"Enemy Health: {enemyHealth} | Enemy Power: {enemyPower}");
            Console.WriteLine("");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|  (A)ttack       (D)efend |");
            Console.WriteLine("|         (P)ower          |");
            Console.WriteLine("|  (R)un          (H)eal   |");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine($"Potions: {hero.Potion} | Health: {hero.Health} | Armor: {hero.Armor} | ");
            hero.ShowPoints();
            Console.WriteLine();
            Console.WriteLine("Choose an action:");
            Console.Write(" > ");
            
            string? input = Console.ReadLine()?.ToLower().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Writing.Print("Please enter a valid action.");
                continue;
            }


            if (hero is Mag mag)
            {
                mag.ProcessTurnEffects();
            }


            switch (input)
            {
                case "a":
                case "attack":
                    Writing.Print($"{hero.Name} attacks the enemy!\n");
                    damage = random.Next(hero.Armor, enemyPower+1) - random.Next(1, hero.Armor);
                    damage = (damage < 0)? 0 : damage;
                    attack = random.Next(0, hero.WeaponValue) + random.Next(2, hero.Damage) + random.Next(1, 4);
                    hero.Health -= damage;
                    enemyHealth -= attack;
                    Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    hero.PointsAdd();

                    statsSaver.fightLog.Add(new FightRound
                    {
                        HeroName = hero.Name,
                        EnemyName = enemyName ?? "Unknown",
                        HeroHealth = hero.Health,
                        EnemyHealth = enemyHealth,
                        Action = "Attack",
                        DamageTaken = damage,
                        DamageDealt = attack
                    });

                    break;

                case "d":
                case "defend":
                    Writing.Print($"{hero.Name} defends!\n");
                    damage = (enemyPower/random.Next(2,4)) - hero.Armor;
                    damage = (damage < 0)? 0 : damage;
                    attack = random.Next(0, hero.WeaponValue)/2 + random.Next(2, hero.Damage)/2;
                    hero.Health -= damage;
                    enemyHealth -= attack;
                    Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    hero.PointsAdd();

                    statsSaver.fightLog.Add(new FightRound
                    {
                        HeroName = hero.Name,
                        EnemyName = enemyName ?? "Unknown",
                        HeroHealth = hero.Health,
                        EnemyHealth = enemyHealth,
                        Action = "Defend",
                        DamageTaken = damage,
                        DamageDealt = attack
                    });
                    break;

                case "p":
                case "power":
                    hero.UseSpecialSkill();
                    if (hero is Mag magHero && magHero.FireballDamage > 0)
                    {
                        attack = magHero.FireballDamage;
                        enemyHealth -= attack;
                        damage = 0;
                        Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                        magHero.FireballDamage = 0;
                    }
                    else if (hero is Warrior warriorHero)
                    {
                        if (warriorHero.Stamina >= 20)
                        {
                            warriorHero.Stamina -= 20;
                            attack = warriorHero.DealPowerStrikeDamage();
                            damage = random.Next(hero.Armor, enemyPower + 1) - random.Next(1, hero.Armor);
                            damage = (damage < 0)? 0 : damage;
                            hero.Health -= damage;
                            enemyHealth -= attack;
                            Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                        }
                    }

                    statsSaver.fightLog.Add(new FightRound
                    {
                        HeroName = hero.Name,
                        EnemyName = enemyName ?? "Unknown",
                        HeroHealth = hero.Health,
                        EnemyHealth = enemyHealth,
                        Action = "Power",
                        DamageTaken = damage,
                        DamageDealt = attack
                    });
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
                        hero.PointsAdd();

                        statsSaver.fightLog.Add(new FightRound
                        {
                            HeroName = hero.Name,
                            EnemyName = enemyName ?? "Unknown",
                            HeroHealth = hero.Health,
                            EnemyHealth = enemyHealth,
                            Action = "Attack",
                            DamageTaken = damage,
                            DamageDealt = attack
                        });

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
                        hero.PointsAdd();
                    }
                    else
                    {
                        Writing.Print("you don't have any potions! That mistake will cost you some bruises.\n");
                        damage = enemyPower - hero.Armor  - random.Next(1,5);
                        damage = (damage < 0)? 0 : damage;
                        hero.Health -= damage;
                        Writing.Print($"{hero.Name} lose " + damage + " health and deal " + attack + " damage\n");
                    }

                    statsSaver.fightLog.Add(new FightRound
                    {
                        HeroName = hero.Name,
                        EnemyName = enemyName ?? "Unknown",
                        HeroHealth = hero.Health,
                        EnemyHealth = enemyHealth,
                        Action = "Attack",
                        DamageTaken = damage,
                        DamageDealt = attack
                    });

                    break;

                default:
                    Writing.Print("Enter a valid option: (A)ttack, (D)efend, (P)ower, (R)un, (H)eal\n");
                    break;
            }
            Console.ReadKey();

            

            if(hero.Health <= 0 || enemyHealth <= 0)
            {
                statsSaver.Save();
            }

            if (hero.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Writing.Print($"{hero.Name} was killed!");
                Console.ResetColor();
                Environment.Exit(0);
                break;
            }

            if(enemyHealth <= 0)
            {
                int gold = random.Next(40, 70);
                hero.Gold += gold;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Writing.Print($"{enemyName} was killed!\n {hero.Name} won!\n");
                Writing.Print($"You earned {gold}$");
                Console.ResetColor();
                Console.ReadKey();
                break;
            }  
        }
    }
}