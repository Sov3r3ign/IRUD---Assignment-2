using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton
            GameManager.GetGameManger().LogBattle("Welcome to CastleForge!");

            //decorator
            Console.WriteLine("=====KNIGHT=====");
            ICharacter character = new BaseKnight("Adam");
            character = new FlameSword(character);
            character = new DragonSlayer(character);
            GameManager.GetGameManger().LogBattle($"Character: [{character.GetDescription()} \nPower: [{character.GetPower()}]");
            Console.WriteLine("=====ARCHER=====");
            ICharacter charArch = new BaseArcher("Sudais");
            charArch = new FlamingArrows(charArch);
            GameManager.GetGameManger().LogBattle($"Character: [{charArch.GetDescription()} \nPower: [{charArch.GetPower()}]");
            Console.WriteLine();
            //Commands
            Character kcommands = new Character(character);
            BattleCommander bc = new BattleCommander();
            GameManager.GetGameManger().LogBattle("[CastleForge Training grounds]");
            GameManager manager = GameManager.GetGameManger();
            manager.ExecuteCommand(new AttackCommand(kcommands));
            manager.ExecuteCommand(new DefendCommand(kcommands));
            manager.ExecuteCommand(new AttackCommand(kcommands));
            manager.UndoAllMoves();

            Console.ReadLine();

        }
    }
}
