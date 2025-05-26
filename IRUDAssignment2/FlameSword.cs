using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class FlameSword : CharacterDecorator
    {
        public FlameSword(ICharacter kcharacter) : base(kcharacter){}
        public override string GetDescription()
        {
            return base.GetDescription() + "\nEquips Flame Sword ";
        }
        public override int GetPower()
        {
            return base.GetPower() + 20;
        }
    }
   
}
