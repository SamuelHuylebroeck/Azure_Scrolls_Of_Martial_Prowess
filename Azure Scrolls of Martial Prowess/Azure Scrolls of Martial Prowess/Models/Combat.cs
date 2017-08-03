using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Combat
    {
        public SortedList<int,Character> Participants { get; set; }

        public Combat()
        {
            this.Participants = new SortedList<int,Character>();
        }

        public Boolean AddCharacter(Character newParticipant)
        {
            Boolean res = false;
            //Check if already present
            if (Participants.ContainsValue(newParticipant)){
                return false;
            }

            Participants.Add(newParticipant.CurrentInitiative, newParticipant);
            return true;
        }

        public Character GetCharacter(String name)
        {
            //Assume no characters with the same name are present
            Character res = null;
            foreach(Character charPres in Participants.Values)
            {
                if(charPres.Name == name)
                {
                    res = charPres;
                    break;
                }
            }
            return res;

        }
    }
}
