using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Game
{
    public class Game
    {
        public bool Start_Game(
            Button startGameButton,
            Button[,] buttons,
            Label turn_player)
        {
            startGameButton.Visible = false;
            foreach (Button button in buttons)
            {
                button.Visible = true;
            }
            turn_player.Visible = true;
            turn_player.Text = "Turn player 1";

            return true;
        }
    }
}
