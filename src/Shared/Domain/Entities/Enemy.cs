
namespace Domain.Entities;

public class Enemy
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }


    public void RandomStatsGenerator()
    {
        Random random = new Random();
        List<string> names = new List<string> { "Orc", "Ghul", "Nazgul", "Goblin" };
        Name = names[random.Next(0, names.Count)];

        switch(Name)
        {
            case "Orc":
                Health = random.Next(60,80);
                Power = random.Next(30,40);
                break;
            case "Ghul":
                Health = random.Next(50,70);
                Power = random.Next(20,30);
                break;
            case "Nazgul":
                Health = random.Next(50,70);
                Power = random.Next(40,50);
                break;
            case "Goblin":
                Health = random.Next(40,50);
                Power = random.Next(20,25);
                break;    
        }
    }
}
