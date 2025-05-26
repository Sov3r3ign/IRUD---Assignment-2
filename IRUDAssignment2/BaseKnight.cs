using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class BaseKnight : ICharacter //Concrete Component
    {
        public string name;
        public BaseKnight(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return $"The Knight: {name}";
        }
        public int GetPower()
        {
            return 45;
        }
    }
}
