using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Character : CharacterTemplate
    {
        public Character(string name,CharacterTemplate template) : base(template.Type, template.Willpower, template.PeripheralEssence, template.PersonalEssence, template.HealthLevels, template.Battlegroup)       
        {
            this.Name = name;
            this.CurrentInitiative = 0;
            this.CurrentPeripheralEssence = this.PeripheralEssence;
            this.CurrentPersonalEssence = this.PersonalEssence;
            this.CurrentWillPower = 0;
            this.CurrentEffects = new List<Effect>();
            this.CurrentHealthLevels = new List<KeyValuePair <string, string>>();
            foreach(String level in HealthLevels)
            {
                CurrentHealthLevels.Add(new KeyValuePair<String,String>(level, "O"));
            }
            this.HasActedThisRound = false;
        }

        public String Name { get; set; }
        public int CurrentInitiative { get; set; }
        public int CurrentWillPower { get; set; }
        public int CurrentPersonalEssence { get; set; }
        public int CurrentPeripheralEssence { get; set; }
        List<KeyValuePair<string, string>> CurrentHealthLevels { get; set; }
        public List<Effect> CurrentEffects { get; }
        public Boolean HasActedThisRound { get; set; }


        public Effect GetEffectByName(String name)
        {
            Effect res = null;
            foreach(Effect e in CurrentEffects)
            {
                if (e.name.Equals(name))
                {
                    res = e;
                    break;
                }
            }
            return res;
        }

    }
}
