using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class HealCommand : ICommand
    {
        private Character knight;
        public HealCommand(Character warrior)
        {
            knight = warrior;
        }
        public void Execute()
        {
            knight.Heal();
        }
        public void Undo()
        {
            knight.UndoMove();
        }
    }
}
