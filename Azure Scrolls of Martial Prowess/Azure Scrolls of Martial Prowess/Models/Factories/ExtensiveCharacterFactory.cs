using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models.Factories
{
    public class ExtensiveCharacterFactory : ICharacterFactory
    {
        public Character CreateCharacter(string code, object[] stats)
        {
            String name = (String)stats[0];
            int essence = (int)stats[1];
            int willpower = (int)stats[2];
            List<String> healthLevels = (List<String>)stats[3];
            Boolean isBattlegroup = (Boolean)stats[4];
            String drill;
            int size, might;
            int persE = CalculatePersonalEssence(code, essence);
            int periE = CalculatePeripheralEssence(code, essence);

            if (!isBattlegroup)
            {
                CharacterTemplate template = new CharacterTemplate(code, essence, willpower, periE, persE, healthLevels, false);
                Character newChar = new Character(name, template);
                return newChar;
            }
            else {
                drill = (String)stats[5];
                size = (int)stats[6];
                might = (int)stats[7];
                CharacterTemplate template = new CharacterTemplate(code, essence, willpower, periE, persE, healthLevels, true);
                Battlegroup battleGroup = new Battlegroup(name, template, might, size, drill);
                return battleGroup;
            }


        }


        private int CalculatePersonalEssence(String code, int essence)
        {
            switch (code)
            {
                case "Mortal":
                    return 0;
                case "Dragonblooded":
                    return 11 + essence;
                case "Lunar":
                    return 15 + essence;
                case "Solar":
                    return 10 + essence * 3;
                default:
                    return 0;
            }
        }

        private int CalculatePeripheralEssence(String code, int essence)
        {
            switch (code)
            {
                case "Mortal":
                    return 0;
                case "Dragonblooded":
                    return 23 + essence * 4;
                case "Lunar":
                    return 34 + essence * 4;
                case "Solar":
                    return 26 + essence * 7;
                default:
                    return 0;
            }
        }
    }

}
