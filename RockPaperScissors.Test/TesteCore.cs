using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Core;
using System.Diagnostics;
using System.Collections.Generic;

namespace RockPaperScissors.Test
{
    [TestClass]
    public class TesteCore
    {
        [TestMethod]
        public void TestGameResult_ShowGameResult()
        {
            string validResult = string.Format(@"[[""{0}""{1}""],[""{2}"",""{3}""]] # {4} would win since {5} > {6}", "Armando", "P", "Dave", "S", "Dave", "S", "P");
            string strResult = "";
            PlayerMove winner = new PlayerMove("Dave", "S");
            PlayerMove looser = new PlayerMove("Armando", "P");
            Match match = new Match(looser, winner);
            GameResult result = new GameResult(winner, looser, match);
            strResult = GameResult.ShowGameResult(result);
            Assert.AreEqual(validResult, strResult);
            Debug.WriteLine(strResult);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestWrongNumberOfPlayersError()
        {
            List<PlayerMove> players = new List<PlayerMove>();
            try
            {
                Rules.rps_game_winner("Armando", "P", "", "");
                Assert.Fail();
            }
            catch (WrongNumberOfPlayersError ex)
            {
                Assert.IsInstanceOfType(ex, new WrongNumberOfPlayersError().GetType());
            }
            catch
            {
                Assert.Fail();
            }
            Debug.WriteLine(new WrongNumberOfPlayersError().Message);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestNoSuchStrategyError()
        {
            try
            {
                Rules.rps_game_winner("Armando", "SS", "", "");
                Assert.Fail();
            }
            catch (NoSuchStrategyError ex)
            {
                Assert.IsInstanceOfType(ex, new NoSuchStrategyError().GetType());
            }
            catch
            {
                Assert.Fail();
            }
            Debug.WriteLine(new NoSuchStrategyError().Message);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestGetGameResult_PlaySameMove()
        {
            var result = Rules.rps_game_winner("Armando", "S", "Dave", "S");
            Assert.AreEqual("Armando", result.Winner.PlayerName);
            Debug.WriteLine(result.Winner.PlayerName);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestGetGameResult_R_beats_S()
        {
            var result1 = Rules.rps_game_winner("Armando", "R", "Dave", "S");
            var result2 = Rules.rps_game_winner("Dave", "S", "Armando", "R");
            Assert.AreEqual("Armando", result1.Winner.PlayerName);
            Assert.AreEqual("Armando", result2.Winner.PlayerName);
            Debug.WriteLine(result1.Winner.PlayerName);
            Debug.WriteLine(result2.Winner.PlayerName);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestGetGameResult_S_beats_P()
        {
            var result1 = Rules.rps_game_winner("Armando", "S", "Dave", "P");
            var result2 = Rules.rps_game_winner("Dave", "P", "Armando", "S");
            Assert.AreEqual("Armando", result1.Winner.PlayerName);
            Assert.AreEqual("Armando", result2.Winner.PlayerName);
            Debug.WriteLine(result1.Winner.PlayerName);
            Debug.WriteLine(result2.Winner.PlayerName);
        }

        [TestMethod]
        public void Rules_rps_game_winner_TestGetGameResult_P_beats_R()
        {
            var result1 = Rules.rps_game_winner("Armando", "P", "Dave", "R");
            var result2 = Rules.rps_game_winner("Dave", "R", "Armando", "P");
            Assert.AreEqual("Armando", result1.Winner.PlayerName);
            Assert.AreEqual("Armando", result2.Winner.PlayerName);
            Debug.WriteLine(result1.Winner.PlayerName);
            Debug.WriteLine(result2.Winner.PlayerName);
        }

        [TestMethod]
        public void Tournament_PlayTournament()
        {
            Tournament tournament = new Tournament();
            var result = tournament.rps_tournament_winner();
            Assert.AreEqual("Richard", result[0, 0]);
            Debug.WriteLine(string.Format(@"[""{0}"",""{1}""]", result[0, 0], result[0, 1]));
        }
    }
}
