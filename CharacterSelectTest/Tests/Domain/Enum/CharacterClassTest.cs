using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                "Robin używa Deszczu Strzał!",
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
                "Shadow używa Cienia Śmierci!",
                assassin.SpecialAbility());
        }
    }
 