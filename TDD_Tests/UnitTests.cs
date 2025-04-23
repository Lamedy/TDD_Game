using System.Windows.Forms;
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

        [Test]
        public void Start_Game()
        {
            Game game = new Game();

            var startGameButton = new Button();

            Button[,] buttons = new Button[3, 3]
            {
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() }
            };

            var turn_player = new Label();

            bool result = game.Start_Game(
                startGameButton,
                buttons,
                turn_player
            );

            Assert.IsFalse(startGameButton.Visible);
            foreach (var button in buttons)
            {
                Assert.IsTrue(button.Visible);
            }
            Assert.IsTrue(turn_player.Visible);
            Assert.That(turn_player.Text, Is.EqualTo("Turn player 1"));
        }
    }
}