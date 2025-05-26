using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class DragonSlayer : CharacterDecorator
    {
        public DragonSlayer(ICharacter character) : base(character)
        {
            
        }
        public override string GetDescription()
        {
            return base.GetDescription() + "\nEquips Dragon Slayer Sword ";
        }
        public override int GetPower()
        {
            return base.GetPower() + 30;
        }
    }
}
