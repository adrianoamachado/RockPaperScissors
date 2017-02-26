using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class Rules
    {
        private static string[] strategyes = { "R", "P", "S" };
        public static GameResult rps_game_winner(string name1, string strategy1, string name2, string strategy2)
        {
            List<PlayerMove> players = new List<PlayerMove>();
            if (!string.IsNullOrEmpty(name1))
                players.Add(AuthorizeStrategy(name1, strategy1.ToUpper()));
            if (!string.IsNullOrEmpty(name2))
                players.Add(AuthorizeStrategy(name2, strategy2.ToUpper()));
            if (players.Count != 2)
            {
                throw new WrongNumberOfPlayersError();
            }
            return GetGameResult(players);
        }

        private static GameResult GetGameResult(List<PlayerMove> players)
        {
            Match match = new Match(players.ElementAt(0), players.ElementAt(1));
            if (match.Player1.Hand == match.Player2.Hand)
            {
                return Player1Win(match);
            }
            else
            {
                switch (match.Player1.Hand)
                {
                    case "R":
                        return match.Player2.Hand == "S" ? Player1Win(match) : Player2Win(match);
                    case "P":
                        return match.Player2.Hand == "R" ? Player1Win(match) : Player2Win(match);
                    case "S":
                        return match.Player2.Hand == "P" ? Player1Win(match) : Player2Win(match);
                    default:
                        throw new Exception("Winner Undefined.");
                }
            }
        }

        private static PlayerMove AuthorizeStrategy(string name, string strategy)
        {
            if (strategyes.Contains(strategy))
            {
                return new PlayerMove(name, strategy);
            }
            else
            {
                throw new NoSuchStrategyError();
            }
        }

        private static GameResult Player1Win(Match match)
        {
            return new GameResult(match.Player1, match.Player2, match);
        }

        private static GameResult Player2Win(Match match)
        {
            return new GameResult(match.Player2, match.Player1, match);
        }

    }
}
