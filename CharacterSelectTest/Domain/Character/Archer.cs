using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
 * klasa: Archer
 *
 * opis:
 * Reprezentuje łucznika, który specjalizuje się w zwinności
 * i walce na odległość.
 *
 * pola / właściwości:
 * Name, string, imię postaci
 * Health, int, punkty życia postaci
 * Strength, int, siła fizyczna postaci
 * Intelligence, int, inteligencja postaci
 * Agility, int, zwinność postaci
 *************************************************************************/
public class Archer : Entity.Character
{/*************************************************************************
     * funkcja: Archer
     *
     * opis:
     * Tworzy łucznika i ustawia jego początkowe statystyki.
     *
     * parametry:
     * name, string, imię tworzonej postaci
     *
     * zwraca:
     * brak
     *************************************************************************/

    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 85;
        Strength = 10;
        Intelligence = 9;
        Agility = 18;
    }

   /*************************************************************************
     * funkcja: Attack
     *
     * opis:
     * Oblicza wartość ataku łucznika na podstawie jego siły.
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
      * Zwraca komunikat o użyciu specjalnej umiejętności łucznika.
      *
      * parametry:
      * brak
      *
      * zwraca:
      * string, komunikat o użyciu Deszczu Strzał
      *************************************************************************/
    public string SpecialAbility()
    {
        return $"{Name} używa Deszczu Strzał!";
    }
}
