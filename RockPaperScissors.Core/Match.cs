using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class Match
    {
        public PlayerMove Player1 { get; set; }
        public PlayerMove Player2 { get; set; }

        public Match(PlayerMove _player1, PlayerMove _player2)
        {
            Player1 = _player1;
            Player2 = _player2;
        }
    }
}
