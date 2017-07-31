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
    }
}
