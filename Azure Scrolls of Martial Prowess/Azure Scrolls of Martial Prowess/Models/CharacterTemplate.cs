using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class CharacterTemplate
    {
        public CharacterTemplate(String Type, int Willpower, int PeripheralEssence,int PersonalEssence, List<String> HealthLevels, Boolean Battlegroup, int Might,int Size, String Drill)
        {
            this.Type = Type;
            this.Willpower = Willpower;
            this.PeripheralEssence = PeripheralEssence;
            this.PersonalEssence = PersonalEssence;
            this.HealthLevels = HealthLevels;
            this.Battlegroup = Battlegroup;
            this.Size = Size;
            this.Drill = Drill;
        }

        public CharacterTemplate(String Type, int Willpower, int PeripheralEssence,int PersonalEssence): this(Type, Willpower, PeripheralEssence, PersonalEssence, null, false, 0, 0, "")
        {
            List<String> hl = new List<String>();
            String[] levels = { "0", "-1", "-1", "-2", "-2", "-4", "Inc" };
            foreach(String level in levels)
            {
                hl.Add(level);
            }
            HealthLevels = hl;
        }

        public String Type { get;  }
        public int Willpower { get;  }
        public int PeripheralEssence { get;  }
        public int PersonalEssence { get;  }
        public List<String> HealthLevels { get;  }
        public Boolean Battlegroup { get;  }
        public int Might { get;  }
        public int Size { get;  }
        public String Drill { get; }

    }
}
