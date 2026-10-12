using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*************************************************************************
 * klasa: Paladin
 *
 * opis:
 * Reprezentuje paladyna, który łączy dużą wytrzymałość
 * z wysoką siłą fizyczną.
 *
 * pola / właściwości:
 * Name, string, imię postaci
 * Health, int, punkty życia postaci
 * Strength, int, siła fizyczna postaci
 * Intelligence, int, inteligencja postaci
 * Agility, int, zwinność postaci
 *************************************************************************/
public class Paladin : Entity.Character
{
    /*************************************************************************
      * funkcja: Paladin
      *
      * opis:
      * Tworzy paladyna i ustawia jego początkowe statystyki.
      *
      * parametry:
      * name, string, imię tworzonej postaci
      *
      * zwraca:
      * brak
      *************************************************************************/
    public Paladin(string name) : base(name, CharacterClass.Paladin)
    {
        Health = 120;
        Strength = 15;
        Intelligence = 8;
        Agility = 7;
    }

    /*************************************************************************
       * funkcja: Attack
       *
       * opis:
       * Oblicza wartość ataku paladyna na podstawie jego siły.
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
     * Zwraca komunikat o użyciu specjalnej umiejętności paladyna.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * string, komunikat o użyciu Świętego Uderzenia
     *************************************************************************/
    public string SpecialAbility()
    {
        return $"{Name} używa Świętego Uderzenia!";
    }
}