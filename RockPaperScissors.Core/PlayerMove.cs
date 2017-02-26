using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class PlayerMove
    {
        public string Hand { get; set; }
        public string PlayerName { get; set; }

        public PlayerMove(string _playerName, string _playerHand)
        {
            PlayerName = _playerName;
            Hand = _playerHand;
        }
    }
}
