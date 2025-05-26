using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class GameManager
    {
        private static GameManager gameManager;
        private static object gameLock = new object();
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        private GameManager(){}
        public static GameManager GetGameManger()
        {
            lock (gameLock)
            {
                if(gameManager == null)
                {
                   gameManager = new GameManager();
                }
            }
            
            return gameManager;
        }
        public void LogBattle(string message)
        {
            //Console.WriteLine("[Overseer of the battle]");
            Console.WriteLine("Game Manager Log: " + message);
        }
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }
        public void UndoAllMoves()
        {
            while (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
            }
        }

    }
}
