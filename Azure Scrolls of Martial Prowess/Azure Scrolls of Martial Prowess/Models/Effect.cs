using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Effect
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Boolean Temporary { get; set; }
        public int RemainingTurns { get; set; }

        public Effect(String name, String description, Boolean temporary, int remainingTurns)
        {
            this.Name = name;
            this.Description = description;
            this.Temporary = temporary;
            this.RemainingTurns = remainingTurns;
        }

        public Effect(String name, String description) : this(name, description, false, -1) { }

        public Effect(String name, String description, int remainingTurns) : this(name, description, true, remainingTurns) { }


    }
}
