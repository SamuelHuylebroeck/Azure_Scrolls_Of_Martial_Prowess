using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure_Scrolls_of_Martial_Prowess.Util;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Character : CharacterTemplate
    {
        public Character(string name, CharacterTemplate template) : base(template.Type,template.Essence, template.Willpower, template.PeripheralEssence, template.PersonalEssence, template.HealthLevels, template.Battlegroup)
        {
            this.Name = name;
            this.CurrentInitiative = 0;
            this.CurrentPeripheralEssence = this.PeripheralEssence;
            this.CurrentPersonalEssence = this.PersonalEssence;
            this.CurrentWillPower = this.Willpower;
            this.CurrentOnslaught = 0;
            
            this.CurrentEffects = new List<Effect>();
            this.CurrentHealthLevels = new List<KeyValuePair<string, Constants.HealthState>>();
            foreach (String level in HealthLevels)
            {
                CurrentHealthLevels.Add(new KeyValuePair<String, Constants.HealthState>(level, Constants.HealthState.UNWOUNDED));
            }
            this.HasActedThisRound = false;
            this.KeepOnslaughtOnAct = false;
        }

        public String Name { get; set; }
        public int CurrentInitiative { get; set; }
        public int CurrentWillPower { get; set; }
        public int CurrentPersonalEssence { get; set; }
        public int CurrentPeripheralEssence { get; set; }
        public int CurrentOnslaught { get; set; }
        public String CurrentAnimaLevel { get; set; }
        public List<KeyValuePair<string, Constants.HealthState>> CurrentHealthLevels { get; set; }
        public List<Effect> CurrentEffects { get; }
        private Boolean hasActedThisRound;
        public Boolean HasActedThisRound
        {
            set
            {
                if (!KeepOnslaughtOnAct && value) {
                    CurrentOnslaught = 0;
                }
                hasActedThisRound = value;
            }

            get
            {
                return hasActedThisRound;
            }
        }
        public Boolean KeepOnslaughtOnAct { get; set; }


        public Effect GetEffectByName(String name)
        {
            Effect res = null;
            foreach (Effect e in CurrentEffects)
            {
                if (e.Name.Equals(name))
                {
                    res = e;
                    break;
                }
            }
            return res;
        }

        public String GetShortDescription()
        {
            String res = "";
            //onslaught
            res += "O:-" + CurrentOnslaught + ", ";
            //essence
            res += "Ps:" + CurrentPersonalEssence + "/" + PersonalEssence + ", Pe:" + CurrentPeripheralEssence + "/" + PeripheralEssence + ", ";
            //Health
            res += "WP:" + CurrentWillPower+", ";
            res += "W:-" + GetGreatestWoundPenalty();
            return res;
        }
        public Boolean IsOut()
        {
            Boolean res = false;
            //A character is out of combat when his incap level is wounded

            //Normally, the incap level is the last one in the health track
            if (CurrentHealthLevels.Last().Key.Equals(Constants.HL_INC))
            {
                res = Constants.IsWoundedHealthLevel(CurrentHealthLevels.Last().Value);

            }
            else
            {
                throw new Exception("Incorrect last health level. It should be " + Constants.HL_INC+", but it is "+ CurrentHealthLevels.Last().Key);
            }
            return res;
        }
        private String GetGreatestWoundPenalty()
        {
            String res = "0";
            //Traverse
            for (int i = 0; i < CurrentHealthLevels.Count; i++)
            {
                //Abort at 
                if (CurrentHealthLevels[i].Value == Constants.HealthState.UNWOUNDED)
                {
                    break;
                }
                else
                {
                    res = CurrentHealthLevels[i].Key;
                }
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            if (!obj.GetType().Equals(this.GetType())) return false;
            Character toCompare = (Character)obj;
            if (toCompare.Name.Equals(this.Name)) return true;
            return base.Equals(obj);
        }
    }
}
