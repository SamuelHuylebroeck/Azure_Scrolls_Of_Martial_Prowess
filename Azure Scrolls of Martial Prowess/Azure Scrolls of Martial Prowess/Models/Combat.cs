using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models
{
    public class Combat
    {
        public List<Character> Participants { get; set; }
       
        public Combat()
        {
            this.Participants = new List<Character>();

        }

        public Boolean AddCharacter(Character newParticipant)
        {
            //Check if already present
            if (Participants.Contains(newParticipant)){
                return false;
            }

            Participants.Add(newParticipant);
            return true;
        }

        public Character GetCharacter(String name)
        {
            //Assume no characters with the same name are present
            Character res = null;
            foreach(Character charPres in Participants)
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
