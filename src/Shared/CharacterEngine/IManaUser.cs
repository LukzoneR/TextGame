
namespace CharacterEngine;

public interface IManaUser
{
    int Mana { get; set; }
    void CastSpell(string spellName);

}
