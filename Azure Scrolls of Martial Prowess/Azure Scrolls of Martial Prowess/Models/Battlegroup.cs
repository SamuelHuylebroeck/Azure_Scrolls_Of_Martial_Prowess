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
            this.CurrentMagnitude = GetCurrentMaxMagnitude();
           
        }

        public int GetCurrentMaxMagnitude()
        {
            return HealthLevels.Count + CurrentSize;
        }

        public new String GetShortDescription()
        {
            String res = "";
            //onslaught
            res += "O:-" + CurrentOnslaught + ", ";

            //Drill
            res += "D: " + Drill + ", ";
            //Size
            res += "S: " + CurrentSize + "/" + Size+", ";
            //Magnitude
            res += "M: " + CurrentMagnitude + "/"+ GetCurrentMaxMagnitude();
            return res;
        }

        public new Boolean IsOut()
        {
            return (CurrentMagnitude <= 0 && Size <= 0);
        }


    }
}
