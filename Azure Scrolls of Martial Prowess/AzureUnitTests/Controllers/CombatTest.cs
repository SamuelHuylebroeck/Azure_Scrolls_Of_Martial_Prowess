using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Azure_Scrolls_of_Martial_Prowess.Models;
using Azure_Scrolls_of_Martial_Prowess.Controllers;

namespace AzureUnitTests
{
    [TestClass]
    public class CombatTest
    {
        [TestMethod]
        public void TestNextRoundMotesPeripheral()
        {
            int periE = 33;
            int persE = 13;
            //Emptied peripheral
            CharacterTemplate basicTemplate = new CharacterTemplate("Test",5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPeripheralEssence = 0;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(5, basicChar.CurrentPeripheralEssence);

        }

        [TestMethod]
        public void TestNextRoundMotesPeripheral2()
        {
            int periE = 33;
            int persE = 13;
            //Emptied peripheral
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPeripheralEssence = 0;
            basicChar.CurrentPersonalEssence = 0;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(5, basicChar.CurrentPeripheralEssence);
            Assert.AreEqual(0, basicChar.CurrentPersonalEssence);

        }

        [TestMethod]
        public void TestNextRoundMotesPersonal()
        {
            int periE = 33;
            int persE = 13;
            //Emptied personal
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPersonalEssence = 0;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(5, basicChar.CurrentPersonalEssence);

        }

        [TestMethod]
        public void TestNextRoundMotesPersonal2()
        {
            int periE = 33;
            int persE = 13;
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPersonalEssence = 5;
            basicChar.CurrentPeripheralEssence = 30;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(30, basicChar.CurrentPeripheralEssence);
            Assert.AreEqual(10, basicChar.CurrentPersonalEssence);

        }

        [TestMethod]
        public void TestNextRoundMotesSplitPeripheral()
        {
            int periE = 33;
            int persE = 13;
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPersonalEssence = 10;
            basicChar.CurrentPeripheralEssence = 30;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(periE, basicChar.CurrentPeripheralEssence);
            Assert.AreEqual(12, basicChar.CurrentPersonalEssence);

        }



        [TestMethod]
        public void TestNextRoundEffects()
        {
            int periE = 33;
            int persE = 13;
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character basicChar = new Character("Lucky", basicTemplate);

            Effect contEffect = new Effect("temp", "3 rounds", 3);
            Effect toRemove = new Effect("temp2", "needs to be removed", 1);
            Effect perm = new Effect("permanent", "should not be removed by next round");

            basicChar.CurrentEffects.Add(contEffect);
            basicChar.CurrentEffects.Add(toRemove);
            basicChar.CurrentEffects.Add(perm);

            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();

            Assert.AreEqual(2, basicChar.GetEffectByName("temp").remainingTurns);
            Assert.AreEqual(null, basicChar.GetEffectByName("temp2"));
            Assert.AreEqual(-1, basicChar.GetEffectByName("permanent").remainingTurns);
        }

        [TestMethod]
        public void TestNextRoundInitiative()
        {
            int periE = 33;
            int persE = 13;
            //Emptied peripheral
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, periE, persE);
            Character participantOne = new Character("Lucy", basicTemplate);

            Character participantTwo = new Character("Sabo", basicTemplate);

            CombatController cc = new CombatController();
            cc.AddCharacter(participantOne);
            cc.AddCharacter(participantTwo);

            participantOne.CurrentInitiative = 5;
            participantTwo.CurrentInitiative = 10;


            cc.NextRound();
            String[] expected = { "Sabo", "Lucy" };
            Assert.AreEqual(0, cc.initiativeList.IndexOfValue(expected[0]));
            Assert.AreEqual(1, cc.initiativeList.IndexOfValue(expected[1]));

            participantTwo.CurrentInitiative = 5;
            participantOne.CurrentInitiative = 10;

            cc.NextRound();
            Assert.AreEqual(1, cc.initiativeList.IndexOfValue(expected[0]));
            Assert.AreEqual(0, cc.initiativeList.IndexOfValue(expected[1]));
        }
    }
}
