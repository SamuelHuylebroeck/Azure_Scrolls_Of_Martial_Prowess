using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Effect
    {
        public Effect(String name, String description, Boolean temporary, int remainingTurns)
        {
            this.name = name;
            this.description = description;
            this.temporary = temporary;
            this.remainingTurns = remainingTurns;
        }

        public Effect(String name, String description) : this(name, description, false, -1) { }

        public Effect(String name, String description, int remainingTurns) : this(name, description, true, remainingTurns) { }

        public String name { get; set; }
        public String description { get; set; }
        public Boolean temporary { get; set; }
        public int remainingTurns { get; set; }
    }
}
