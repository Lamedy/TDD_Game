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

        [Test]
        public void Turn_Player_1()
        {
            Game game = new Game();

            var somePanelButton = new Button();
            var turn_player_label = new Label();

            string result = game.Next_Turn(somePanelButton, turn_player_label);

            Assert.That(result, Is.EqualTo("0"));
        }

        [Test]
        public void Player_1_Win_Horizont_Line()
        {
            Game game = new Game();

            Button[,] buttons = new Button[3, 3]
            {
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() }
            };

            var turn_player_label = new Label();

            game.Next_Turn(buttons[0, 0], turn_player_label);   // Игрок 1
            game.Next_Turn(buttons[1, 0], turn_player_label);   // Игрок 2
            game.Next_Turn(buttons[0, 1], turn_player_label);   // Игрок 1
            game.Next_Turn(buttons[1, 1], turn_player_label);   // Игрок 2
            game.Next_Turn(buttons[0, 2], turn_player_label);   // Игрок 1 - победил

            bool result = game.Check_Win(buttons);

            Assert.IsTrue(result);
        }

        [Test]
        public void Player_1_Win_Vertical_Line()
        {
            Game game = new Game();

            Button[,] buttons = new Button[3, 3]
            {
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() },
                { new Button(), new Button(), new Button() }
            };

            var turn_player_label = new Label();

            game.Next_Turn(buttons[0, 0], turn_player_label);   // Игрок 1
            game.Next_Turn(buttons[0, 1], turn_player_label);   // Игрок 2
            game.Next_Turn(buttons[1, 0], turn_player_label);   // Игрок 1
            game.Next_Turn(buttons[1, 1], turn_player_label);   // Игрок 2
            game.Next_Turn(buttons[2, 0], turn_player_label);   // Игрок 1 - победил

            bool result = game.Check_Win(buttons);

            Assert.IsTrue(result);
        }
    }
}