using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class AttackCommand : ICommand
    {
        private Character knight;
        public AttackCommand(Character warrior)
        {
            knight = warrior;
        }
        public void Execute()
        {
            knight.Attack();
        }
        public void Undo()
        {
            knight.UndoMove();
        }
    }
}
