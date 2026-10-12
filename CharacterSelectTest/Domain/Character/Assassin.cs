using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
 * klasa: Assassin
 *
 * opis:
 * Reprezentuje zabójcę, który specjalizuje się w szybkości,
 * zwinności i zadawaniu obrażeń.
 *
 * pola / właściwości:
 * Name, string, imię postaci
 * Health, int, punkty życia postaci
 * Strength, int, siła fizyczna postaci
 * Intelligence, int, inteligencja postaci
 * Agility, int, zwinność postaci
 *************************************************************************/
public class Assassin : Entity.Character
{
    /*************************************************************************
      * funkcja: Assassin
      *
      * opis:
      * Tworzy zabójcę i ustawia jego początkowe statystyki.
      *
      * parametry:
      * name, string, imię tworzonej postaci
      *
      * zwraca:
      * brak
      *************************************************************************/
    public Assassin(string name) : base(name, CharacterClass.Assassin)
    {
        Health = 75;
        Strength = 14;
        Intelligence = 10;
        Agility = 20;
    }

    /*************************************************************************
      * funkcja: Attack
      *
      * opis:
      * Oblicza wartość ataku zabójcy na podstawie jego siły.
      *
      * parametry:
      * brak
      *
      * zwraca:
      * int, wartość ataku równa sile pomnożonej przez 3
      *************************************************************************/
    public int Attack()
    {
        return Strength * 3;
    }

    /*************************************************************************
     * funkcja: SpecialAbility
     *
     * opis:
     * Zwraca komunikat o użyciu specjalnej umiejętności zabójcy.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * string, komunikat o użyciu Cienia Śmierci
     *************************************************************************/
    public string SpecialAbility()
    {
        return $"{Name} używa Cienia Śmierci!";
    }
}
