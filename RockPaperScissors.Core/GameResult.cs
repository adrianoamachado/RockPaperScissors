using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class GameResult
    {
        public PlayerMove Winner;
        public PlayerMove Looser;
        public Match Match { get; set; }

        public GameResult(PlayerMove _winner, PlayerMove _looser, Match _match)
        {
            Winner = _winner;
            Looser = _looser;
            Match = _match;
        }
        public static string ShowGameResult(GameResult _result)
        {
            return string.Format(@"[[""{0}""{1}""],[""{2}"",""{3}""]] # {4} would win since {5} > {6}", 
                _result.Match.Player1.PlayerName, _result.Match.Player1.Hand,
                _result.Match.Player2.PlayerName, _result.Match.Player2.Hand,
                _result.Winner.PlayerName, _result.Winner.Hand, _result.Looser.Hand
                );
        }
    }
}
