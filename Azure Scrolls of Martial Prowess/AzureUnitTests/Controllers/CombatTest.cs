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
            
            //Emptied peripheral
            CharacterTemplate basicTemplate = new CharacterTemplate("Test",5,33,13);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPeripheralEssence = 0;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(5, basicChar.CurrentPeripheralEssence);

        }

        [TestMethod]
        public void TestNextRoundMotesPersonal()
        {

            //Emptied peripheral
            CharacterTemplate basicTemplate = new CharacterTemplate("Test", 5, 33, 13);
            Character basicChar = new Character("Lucky", basicTemplate);
            basicChar.CurrentPersonalEssence = 0;
            CombatController cc = new CombatController();
            cc.AddCharacter(basicChar);
            cc.NextRound();
            Assert.AreEqual(5, basicChar.CurrentPeripheralEssence);

        }

        [TestMethod]
        public void TestNextRoundEffects()
        {
            //Create single character
        }

        [TestMethod]
        public void TestNextRoundInitiative()
        {
            //Create single character
        }
    }
}
