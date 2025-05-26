using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    interface ICharacter //Component
    {
        string GetName();
        string GetDescription();
        int GetPower();
    }
}
