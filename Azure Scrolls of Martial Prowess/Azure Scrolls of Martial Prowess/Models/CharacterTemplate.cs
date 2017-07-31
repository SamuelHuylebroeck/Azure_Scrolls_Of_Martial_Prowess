using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class CharacterTemplate
    {
        public int Type { get;  }
        public int Willpower { get;  }
        public int PeripheralEssence { get;  }
        public int PersonalEssence { get;  }
        public Dictionary<String,int> HealthLevels { get;  }
        public Boolean Battlegroup { get;  }
        public int Might { get;  }
        public int Size { get;  }
        public String Drill { get; }

    }
}
