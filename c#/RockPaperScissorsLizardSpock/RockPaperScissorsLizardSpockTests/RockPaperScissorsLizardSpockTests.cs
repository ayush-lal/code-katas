using NUnit.Framework;
using RockPaperScissorsLizardSpock;
using static RockPaperScissorsLizardSpock.GameService;

namespace RockPaperScissorsLizardSpockTests
{
    public partial class Tests
    {
        [TestFixture]
        public class ActionTests : TestSetup
        {
            [Test]
            public void GivenGame_WhenEvaluate_ThenReturnShouldNotBeNull()
            {
                Assert.IsNotNull(_gameService.Evaluate(Move.Rock, Move.Rock));
            }

            [Test]
            public void GivenGame_WhenValidTie_ThenReturnTrue()
            {
                Assert.IsTrue(_gameService.IsTie(Move.Rock, Move.Rock));
            }

            [Test]
            public void GivenGame_WhenValidDefeat_ThenReturnTrue()
            {
                Assert.IsTrue(_gameService.Defeats(Move.Rock, Move.Scissors));
            }
        }

        [TestFixture]
        public class RockTests : TestSetup
        {
            [Test]
            public void GivenGame_WhenRockVersusRock_ThenValidTie()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Rock, Move.Rock),
                    Result.Tie);
            }
            
            [Test]
            public void GivenGame_WhenRockVersusScissors_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Rock, Move.Scissors),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenRockVersusLizard_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Rock, Move.Lizard),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenRockVersusPaper_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Rock, Move.Paper),
                    Result.Lose);
            }
            
            [Test]
            public void GivenGame_WhenRockVersusSpock_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Rock, Move.Spock),
                    Result.Lose);
            }
        }
        
        [TestFixture]
        public class PaperTests : TestSetup
        {
            [Test]
            public void GivenGame_WhenPaperVersusPaper_ThenValidTie()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Paper, Move.Paper),
                    Result.Tie);
            }
            
            [Test]
            public void GivenGame_WhenPaperVersusRock_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Paper, Move.Rock),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenPaperVersusSpock_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Paper, Move.Spock),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenPaperVersusScissors_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Paper, Move.Scissors),
                    Result.Lose);
            }
            
            [Test]
            public void GivenGame_WhenPaperVersusLizard_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Paper, Move.Lizard),
                    Result.Lose);
            }
        }
        
        [TestFixture]
        public class Lizard : TestSetup
        {
            [Test]
            public void GivenGame_WhenLizardVersusLizard_ThenValidTie()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Lizard, Move.Lizard),
                    Result.Tie);
            }
            
            [Test]
            public void GivenGame_WhenLizardVersusSpock_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Lizard, Move.Spock),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenLizardVersusPaper_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Lizard, Move.Paper),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenLizardVersusRock_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Lizard, Move.Rock),
                    Result.Lose);
            }
            
            [Test]
            public void GivenGame_WhenLizardVersusScissors_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Lizard, Move.Scissors),
                    Result.Lose);
            }
        }
        
        [TestFixture]
        public class Spock : TestSetup
        {
            [Test]
            public void GivenGame_WhenSpockVersusSpock_ThenValidTie()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Spock, Move.Spock),
                    Result.Tie);
            }
            
            [Test]
            public void GivenGame_WhenSpockVersusScissors_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Spock, Move.Scissors),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenSpockVersusRock_ThenValidWin()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Spock, Move.Rock),
                    Result.Win);
            }
            
            [Test]
            public void GivenGame_WhenSpockVersusLizard_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Spock, Move.Lizard),
                    Result.Lose);
            }
            
            [Test]
            public void GivenGame_WhenSpockVersusPaper_ThenValidLoss()
            {
                Assert.AreEqual(
                    _gameService.Evaluate(Move.Spock, Move.Paper),
                    Result.Lose);
            }
        }
    }
}