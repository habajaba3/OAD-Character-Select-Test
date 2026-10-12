using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests;

    Powiedziałeś(-aś):

    musisz napisac ni dokumentacje do jednego pliku, z pszykladu: 
    Dokumentację możecie umieszczać bezpośrednio nad klasą/metodą, np.:

    /*************************************************************************
     * funkcja: Attack
     *
     * opis:
     * Oblicza wartość ataku postaci.
     *
     * parametry:
     * multiplier, int, mnożnik wartości ataku
     *
     * zwraca:
     * int, obliczona wartość ataku
     *************************************************************************/
    public int Attack(int multiplier)
    {
        return Strength * multiplier;
    }                                                                                                                                                                         do kodu using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CharacterSelectTest.Domain.Character;

    namespace CharacterSelectTest.Tests;

    /// <summary>
    /// Testuje tworzenie nowych postaci, ich statystyki,
    /// ataki oraz umiej�tno�ci specjalne.
    /// </summary>
    [TestClass]
    public class NewCharacterTests
    {
        [TestMethod]
        public void Paladin_ShouldHaveCorrectStatistics()
        {
            var paladin = new Paladin("Arthur");

            Assert.AreEqual("Arthur", paladin.Name);
            Assert.AreEqual(120, paladin.Health);
            Assert.AreEqual(15, paladin.Strength);
            Assert.AreEqual(8, paladin.Intelligence);
            Assert.AreEqual(7, paladin.Agility);
        }

        [TestMethod]
        public void Paladin_Attack_ShouldReturn45()
        {
            var paladin = new Paladin("Arthur");

            Assert.AreEqual(45, paladin.Attack());
        }

        [TestMethod]
        public void Paladin_SpecialAbility_ShouldReturnCorrectMessage()
        {
            var paladin = new Paladin("Arthur");

            Assert.AreEqual(
                "Arthur u�ywa �wi�tego Uderzenia!",
                paladin.SpecialAbility());
        }

        [TestMethod]
        public void Archer_ShouldHaveCorrectStatistics()
        {
            var archer = new Archer("Robin");

            Assert.AreEqual("Robin", archer.Name);
            Assert.AreEqual(85, archer.Health);
            Assert.AreEqual(10, archer.Strength);
            Assert.AreEqual(9, archer.Intelligence);
            Assert.AreEqual(18, archer.Agility);
        }

        [TestMethod]
        public void Archer_Attack_ShouldReturn30()
        {
            var archer = new Archer("Robin");

            Assert.AreEqual(30, archer.Attack());
        }

        [TestMethod]
        public void Archer_SpecialAbility_ShouldReturnCorrectMessage()
        {
            var archer = new Archer("Robin");

            Assert.AreEqual(
                "Robin u�ywa Deszczu Strza�!",
                archer.SpecialAbility());
        }

        [TestMethod]
        public void Assassin_ShouldHaveCorrectStatistics()
        {
            var assassin = new Assassin("Shadow");

            Assert.AreEqual("Shadow", assassin.Name);
            Assert.AreEqual(75, assassin.Health);
            Assert.AreEqual(14, assassin.Strength);
            Assert.AreEqual(10, assassin.Intelligence);
            Assert.AreEqual(20, assassin.Agility);
        }

        [TestMethod]
        public void Assassin_Attack_ShouldReturn42()
        {
            var assassin = new Assassin("Shadow");

            Assert.AreEqual(42, assassin.Attack());
        }

        [TestMethod]
        public void Assassin_SpecialAbility_ShouldReturnCorrectMessage()
        {
            var assassin = new Assassin("Shadow");

            Assert.AreEqual(
                "Shadow u�ywa Cienia �mierci!",
                assassin.SpecialAbility());
        }
    }

ChatGPT powiedział:

Poniżej masz dokumentację do całego pliku, napisaną w stylu podanego przykładu. Komentarze są umieszczone bezpośrednio nad klasą i każdą metodą testową.
csharp

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

/*************************************************************************
 * klasa: NewCharacterTests
 *
 * opis:
 * Klasa zawiera testy jednostkowe sprawdzające poprawność tworzenia
 * nowych postaci, ich statystyki, wartość ataku oraz działanie
 * umiejętności specjalnych.
 *
 * metody:
 * Paladin_ShouldHaveCorrectStatistics - sprawdza statystyki paladyna
 * Paladin_Attack_ShouldReturn45 - sprawdza wartość ataku paladyna
 * Paladin_SpecialAbility_ShouldReturnCorrectMessage - sprawdza
 * komunikat umiejętności specjalnej paladyna
 * Archer_ShouldHaveCorrectStatistics - sprawdza statystyki łucznika
 * Archer_Attack_ShouldReturn30 - sprawdza wartość ataku łucznika
 * Archer_SpecialAbility_ShouldReturnCorrectMessage - sprawdza
 * komunikat umiejętności specjalnej łucznika
 * Assassin_ShouldHaveCorrectStatistics - sprawdza statystyki zabójcy
 * Assassin_Attack_ShouldReturn42 - sprawdza wartość ataku zabójcy
 * Assassin_SpecialAbility_ShouldReturnCorrectMessage - sprawdza
 * komunikat umiejętności specjalnej zabójcy
 *************************************************************************/
[TestClass]
public class NewCharacterTests
{
    /*************************************************************************
     * funkcja: Paladin_ShouldHaveCorrectStatistics
     *
     * opis:
     * Sprawdza, czy nowo utworzony paladyn posiada poprawną nazwę
     * oraz prawidłowe wartości statystyk: zdrowia, siły, inteligencji
     * i zręczności.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; w przypadku niezgodności
     * oczekiwanych i rzeczywistych wartości test kończy się błędem
     *************************************************************************/
    [TestMethod]
    public void Paladin_ShouldHaveCorrectStatistics()
    {
        var paladin = new Paladin("Arthur");

        Assert.AreEqual("Arthur", paladin.Name);
        Assert.AreEqual(120, paladin.Health);
        Assert.AreEqual(15, paladin.Strength);
        Assert.AreEqual(8, paladin.Intelligence);
        Assert.AreEqual(7, paladin.Agility);
    }
    /*************************************************************************
     * funkcja: Paladin_Attack_ShouldReturn45
     *
     * opis:
     * Sprawdza, czy metoda Attack() dla paladyna zwraca
     * oczekiwaną wartość ataku równą 45.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * wyniku ataku z oczekiwaną wartością 45
     *************************************************************************/
    [TestMethod]
    public void Paladin_Attack_ShouldReturn45()
    {
        var paladin = new Paladin("Arthur");

        Assert.AreEqual(45, paladin.Attack());
    }

    /*************************************************************************
     * funkcja: Paladin_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna paladyna zwraca
     * poprawny komunikat informujący o użyciu Świętego Uderzenia.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/
    [TestMethod]
    public void Paladin_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var paladin = new Paladin("Arthur");

        Assert.AreEqual(
            "Arthur używa Świętego Uderzenia!",
            paladin.SpecialAbility());
    }

    /*************************************************************************
     * funkcja: Archer_ShouldHaveCorrectStatistics
     *
     * opis:
     * Sprawdza, czy nowo utworzony łucznik posiada poprawną nazwę
     * oraz prawidłowe wartości statystyk: zdrowia, siły, inteligencji
     * i zręczności.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; w przypadku niezgodności
     * oczekiwanych i rzeczywistych wartości test kończy się błędem
     *************************************************************************/
    [TestMethod]
    public void Archer_ShouldHaveCorrectStatistics()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual("Robin", archer.Name);
        Assert.AreEqual(85, archer.Health);
        Assert.AreEqual(10, archer.Strength);
        Assert.AreEqual(9, archer.Intelligence);
        Assert.AreEqual(18, archer.Agility);
    }

    /*************************************************************************
     * funkcja: Archer_Attack_ShouldReturn30
     *
     * opis:
     * Sprawdza, czy metoda Attack() dla łucznika zwraca
     * oczekiwaną wartość ataku równą 30.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * wyniku ataku z oczekiwaną wartością 30
     *************************************************************************/
    [TestMethod]
    public void Archer_Attack_ShouldReturn30()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual(30, archer.Attack());
    }

    /*************************************************************************
     * funkcja: Archer_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna łucznika zwraca
     * poprawny komunikat informujący o użyciu Deszczu Strzał.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/
    [TestMethod]
    public void Archer_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual(
            "Robin używa Deszczu Strzał!",
            archer.SpecialAbility());
    }

    /*************************************************************************
     * funkcja: Assassin_ShouldHaveCorrectStatistics
     *
     * opis:
     * Sprawdza, czy nowo utworzony zabójca posiada poprawną nazwę
     * oraz prawidłowe wartości statystyk: zdrowia, siły, inteligencji
     * i zręczności.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; w przypadku niezgodności
     * oczekiwanych i rzeczywistych wartości test kończy się błędem
     *************************************************************************/
    [TestMethod]
    public void Assassin_ShouldHaveCorrectStatistics()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual("Shadow", assassin.Name);
        Assert.AreEqual(75, assassin.Health);
        Assert.AreEqual(14, assassin.Strength);
        Assert.AreEqual(10, assassin.Intelligence);
        Assert.AreEqual(20, assassin.Agility);
    }

    /*************************************************************************
     * funkcja: Assassin_Attack_ShouldReturn42
     *
     * opis:
     * Sprawdza, czy metoda Attack() dla zabójcy zwraca
     * oczekiwaną wartość ataku równą 42.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * wyniku ataku z oczekiwaną wartością 42
     *************************************************************************/
    [TestMethod]
    public void Assassin_Attack_ShouldReturn42()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual(42, assassin.Attack());
    }

    /*************************************************************************
     * funkcja: Assassin_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna zabójcy zwraca
     * poprawny komunikat informujący o użyciu Cienia Śmierci.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/

    [TestMethod]
    public void Assassin_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual(
            "Shadow używa Cienia Śmierci!",
            assassin.SpecialAbility());
    }

    /*************************************************************************
     * funkcja: Paladin_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna paladyna zwraca
     * poprawny komunikat informujący o użyciu Świętego Uderzenia.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/

ChatGPT to AI i może się mylić.
Czat z ChatGPT
Korzystamy z plików cookie
    [TestMethod]
    public void Paladin_Attack_ShouldReturn45()
    {
        var paladin = new Paladin("Arthur");

        Assert.AreEqual(45, paladin.Attack());
    }

    [TestMethod]
    public void Paladin_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var paladin = new Paladin("Arthur");

        Assert.AreEqual(
            "Arthur u�ywa �wi�tego Uderzenia!",
            paladin.SpecialAbility());
    }

    /*************************************************************************
     * funkcja: Archer_ShouldHaveCorrectStatistics
     *
     * opis:
     * Sprawdza, czy nowo utworzony łucznik posiada poprawną nazwę
     * oraz prawidłowe wartości statystyk: zdrowia, siły, inteligencji
     * i zręczności.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; w przypadku niezgodności
     * oczekiwanych i rzeczywistych wartości test kończy się błędem
     *************************************************************************/

    [TestMethod]
    public void Archer_ShouldHaveCorrectStatistics()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual("Robin", archer.Name);
        Assert.AreEqual(85, archer.Health);
        Assert.AreEqual(10, archer.Strength);
        Assert.AreEqual(9, archer.Intelligence);
        Assert.AreEqual(18, archer.Agility);
    }
    /*************************************************************************
     * funkcja: Archer_Attack_ShouldReturn30
     *
     * opis:
     * Sprawdza, czy metoda Attack() dla łucznika zwraca
     * oczekiwaną wartość ataku równą 30.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * wyniku ataku z oczekiwaną wartością 30
     *************************************************************************/
    [TestMethod]
    public void Archer_Attack_ShouldReturn30()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual(30, archer.Attack());
    }
    /*************************************************************************
     * funkcja: Archer_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna łucznika zwraca
     * poprawny komunikat informujący o użyciu Deszczu Strzał.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/
    [TestMethod]
    public void Archer_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var archer = new Archer("Robin");

        Assert.AreEqual(
            "Robin u�ywa Deszczu Strza�!",
            archer.SpecialAbility());
    }
    /*************************************************************************
     * funkcja: Assassin_ShouldHaveCorrectStatistics
     *
     * opis:
     * Sprawdza, czy nowo utworzony zabójca posiada poprawną nazwę
     * oraz prawidłowe wartości statystyk: zdrowia, siły, inteligencji
     * i zręczności.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; w przypadku niezgodności
     * oczekiwanych i rzeczywistych wartości test kończy się błędem
     *************************************************************************/
    [TestMethod]
    public void Assassin_ShouldHaveCorrectStatistics()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual("Shadow", assassin.Name);
        Assert.AreEqual(75, assassin.Health);
        Assert.AreEqual(14, assassin.Strength);
        Assert.AreEqual(10, assassin.Intelligence);
        Assert.AreEqual(20, assassin.Agility);
    }
     /*************************************************************************
     * funkcja: Assassin_Attack_ShouldReturn42
     *
     * opis:
     * Sprawdza, czy metoda Attack() dla zabójcy zwraca
     * oczekiwaną wartość ataku równą 42.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * wyniku ataku z oczekiwaną wartością 42
     *************************************************************************/
    [TestMethod]
    public void Assassin_Attack_ShouldReturn42()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual(42, assassin.Attack());
    }
     /*************************************************************************
     * funkcja: Assassin_SpecialAbility_ShouldReturnCorrectMessage
     *
     * opis:
     * Sprawdza, czy umiejętność specjalna zabójcy zwraca
     * poprawny komunikat informujący o użyciu Cienia Śmierci.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * void, metoda nie zwraca wartości; test sprawdza zgodność
     * komunikatu z oczekiwanym tekstem
     *************************************************************************/
    [TestMethod]
    public void Assassin_SpecialAbility_ShouldReturnCorrectMessage()
    {
        var assassin = new Assassin("Shadow");

        Assert.AreEqual(
            "Shadow u�ywa Cienia �mierci!",
            assassin.SpecialAbility());
    }
}