using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class DefendCommand : ICommand
    {
        private Character knight;
        public DefendCommand(Character warrior)
        {
            knight = warrior;
        }
        public void Execute()
        {
            knight.Defend();
        }
        public void Undo()
        {
            knight.UndoMove();
        }
    }
}
