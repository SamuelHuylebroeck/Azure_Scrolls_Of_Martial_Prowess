using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_Scrolls_of_Martial_Prowess.Models.Factories
{
    interface ICharacterFactory
    {

        Character CreateCharacter(String code, object[] stats);
    }
}
