using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter knightCharacter;
        public CharacterDecorator(ICharacter knightCharacter)
        {
            this.knightCharacter = knightCharacter;
        }
        public virtual string GetName()
        {
            return knightCharacter.GetName();
        }
        public virtual string GetDescription()
        {
            return knightCharacter.GetDescription();
        }
        public virtual int GetPower()
        {
            return knightCharacter.GetPower();
        }
    }
}
