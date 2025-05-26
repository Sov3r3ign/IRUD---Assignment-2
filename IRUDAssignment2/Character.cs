using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRUDAssignment2
{
    class Character
    {
        private ICharacter _character;
        public Character(ICharacter name)
        {
            _character = name;
        }
        public void Attack()
        {
            GameManager.GetGameManger().LogBattle($"{_character.GetName()} lauches an attack!");
        }
        public void Defend()
        {
            GameManager.GetGameManger().LogBattle($"{_character.GetName()} puts up his Guard!");
        }
        public void Heal()
        {
            GameManager.GetGameManger().LogBattle($"{_character.GetName()} heals up!");
        }
        public void UndoMove()
        {
            GameManager.GetGameManger().LogBattle($"{_character.GetName()} Retreats!");
        }
    }
}
