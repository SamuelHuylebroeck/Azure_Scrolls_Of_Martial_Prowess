using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Util
{
    public class Constants
    {
        public static String DRILL_POOR = "Poor";
        public static String DRILL_AVERAGE = "Average";
        public static String DRILL_ELITE = "Elite";
        public static String ANIMA_DIM = "Dim";
        public static String ANIMA_GLOWING = "Glowing";
        public static String ANIMA_BURNING = "Burning";
        public static String ANIMA_BONFIRE = "Bonfire";
        public static String HL_INC = "Inc";
        public static String[] ALLOWED_ANIMA_LEVELS = { ANIMA_DIM, ANIMA_GLOWING, ANIMA_BURNING, ANIMA_BONFIRE };
        public enum Characteristic
        {
            INIT, //initiative
            PSE, //Personal Essence
            PRE, //Peripheral Essence
            A, //Anima
            HL,//Health levels
            WP, //Willpower
            O //Onslaught
        }

        public enum HealthState
        {
            UNWOUNDED,
            BASHING,
            LETHAL
        }

        public static String[] ALLOWED_HL_STRINGS = { "O", "\\", "X" };

        public static String HealthStateToString(HealthState state)
        {
            String res = "";
            switch (state)
            {
                case HealthState.UNWOUNDED:
                    res = ALLOWED_HL_STRINGS[0];
                    break;
                case HealthState.BASHING:
                    res = ALLOWED_HL_STRINGS[1];
                    break;
                case HealthState.LETHAL:
                    res = ALLOWED_HL_STRINGS[2];
                    break;
                default:
                    break;
            }
            return res;
        }
        public static HealthState StringToHealthState(String hsString)
        {
            switch (hsString)
            {
                case "O":
                    return HealthState.UNWOUNDED;

                case "\\":
                    return HealthState.BASHING;
                case "X":
                    return HealthState.LETHAL;
                default:
                    return HealthState.UNWOUNDED;
            }

        }
        public static bool IsHealthLevelAllowed(String hl)
        {
            return ALLOWED_HL_STRINGS.Contains(hl);
        }

        public static bool IsAnimaStringAllowed(String al)
        {
            return ALLOWED_ANIMA_LEVELS.Contains(al);
        }

        public static Boolean IsWoundedHealthLevel(String hl)
        {
            return hl.Equals(ALLOWED_HL_STRINGS[1]) || hl.Equals(ALLOWED_HL_STRINGS[2]);
        }

        public static Boolean IsWoundedHealthLevel(HealthState hs)
        {
            return hs.Equals(HealthState.BASHING) || hs.Equals(HealthState.LETHAL);

        }
    }
}
