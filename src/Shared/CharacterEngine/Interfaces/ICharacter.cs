
namespace CharacterEngine;
public interface ICharacter
{
    string? Name { get; set; }
    int Health { get; set; }
    int Damage { get; set; }
    int Gold { get; set; }
    int Armor { get; set; }
    string? Weapon { get; set; }
    int Potion { get; set; }

    void DisplayStats();
}
