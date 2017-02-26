using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class Tournament
    {
        private string[,] tournament = new string[8, 2];
        public Tournament()
        {
            tournament[0, 0] = "Arnaldo";
            tournament[1, 0] = "Dave";
            tournament[2, 0] = "Richard";
            tournament[3, 0] = "Michael";
            tournament[4, 0] = "Allen";
            tournament[5, 0] = "Omer";
            tournament[6, 0] = "David E.";
            tournament[7, 0] = "Richard X.";
            tournament[0, 1] = "P";
            tournament[1, 1] = "S";
            tournament[2, 1] = "R";
            tournament[3, 1] = "S";
            tournament[4, 1] = "S";
            tournament[5, 1] = "P";
            tournament[6, 1] = "R";
            tournament[7, 1] = "P";
        }

        public string[,] rps_tournament_winner()
        {
            string[,] nextround;
            nextround = tournament;
            do
            {
                nextround = PlayRound(nextround);
            } while (nextround.Length > 2);

            return nextround;
        }

        private string[,] PlayRound(string[,] players)
        {
            int PlayersInRound = players.Length / 2;
            int PlayersNextRound = PlayersInRound / 2;
            string[,] round = new string[PlayersNextRound, 2];
            for (int i = 0; i < PlayersInRound; i+=2)
            {
                var result = Rules.rps_game_winner(players[i, 0], players[i, 1], players[i + 1, 0], players[i + 1, 1]);
                round[i / 2, 0] = result.Winner.PlayerName;
                round[i / 2, 1] = result.Winner.Hand;
            }
            return round;
        }
    }
}
