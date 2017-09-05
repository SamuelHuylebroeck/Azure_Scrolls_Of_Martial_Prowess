using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess
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
        public static String[] ALLOWED_ANIMA_LEVELS = { ANIMA_DIM, ANIMA_GLOWING, ANIMA_BURNING, ANIMA_BONFIRE };
        public enum Characteristic{
            INIT, //initiative
            PSE, //Personal Essence
            PRE, //Peripheral Essence
            A, //Anima
            HL,//Health levels
            WP //Willpower
        }

    }
}
