using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class FlamingArrows : CharacterDecorator
    {
        public FlamingArrows(ICharacter kcharacter) : base(kcharacter) { }
        public override string GetDescription()
        {
            return base.GetDescription() + "\nEquips Flaming Arrows ";
        }
        public override int GetPower()
        {
            return base.GetPower() + 15;
        }
    }
}
