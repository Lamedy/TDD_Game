using TDD_Game;

namespace TDD_Tests
{
    public class UnitTests
    {
        [Test]
        public void Create_New_Game()
        {
            Game game = new Game();

            Assert.NotNull(game, "Game is not exist.");
        }
    }
}