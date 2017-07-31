using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Character : CharacterTemplate
    {
        public String Name { get; set; }
        public int CurrentInitiative { get; set; }
        public int CurrentWillPower { get; set; }
        public int CurrentPersonalEssence { get; set; }
        public int CurrentPeripheralEssence { get; set; }
        public Dictionary<String, Dictionary<int,String>> CurrentHealthLevels { get; set; } //Penalty, nr, state. eg. -2, 1, bashing
        public List<Effect> CurrentEffects { get; set; }
        public Boolean HasActedThisRound { get; set; }

    }
}
