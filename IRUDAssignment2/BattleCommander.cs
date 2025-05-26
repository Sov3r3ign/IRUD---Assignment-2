using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class BattleCommander
    {
        private ICommand battleCommand;
        public void setCommand(ICommand command)
        {
            battleCommand = command;
        }
        public void executeCommand()
        {
            battleCommand.Execute();
        }
    }
}
