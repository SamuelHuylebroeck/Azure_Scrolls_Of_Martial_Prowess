using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Battlegroup : Character
    {
        public int Might { get; }
        public int Size { get; }
        public String Drill { get; }
        public int CurrentSize { get; set; }
        public int CurrentMagnitude { get; set; }
        public Battlegroup(String name, CharacterTemplate template, int Might, int Size, String Drill) : base(name, template)
        {
            this.Might = Might;
            this.Size = Size;
            this.Drill = Drill;
            this.CurrentSize = Size;
            this.CurrentMagnitude = HealthLevels.Count + CurrentSize;
           
        }


        

    }
}
