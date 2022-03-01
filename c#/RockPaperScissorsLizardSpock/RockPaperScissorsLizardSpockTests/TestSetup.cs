using NUnit.Framework;
using RockPaperScissorsLizardSpock;

namespace RockPaperScissorsLizardSpockTests
{

    public partial class Tests
    {
        public partial class TestSetup
        {
            public GameService _gameService;

            [SetUp]
            public void Setup()
            {
                _gameService = new GameService();
            }
        }
    }

}