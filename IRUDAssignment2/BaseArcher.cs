using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class BaseArcher : ICharacter
    {
        public string name;
        public BaseArcher(string archerName)
        {
            this.name = archerName;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return $"The Archer: {name}";
        }
        public int GetPower()
        {
            return 45;
        }
    }
}
