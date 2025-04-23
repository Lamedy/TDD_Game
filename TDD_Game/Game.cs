using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Game
{
    public class Game
    {
        bool turn_status = false;

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


        public string Next_Turn(Button somePanelButton, Label turn_player_label)
        {
            string playerSymbol = "0";

            if (turn_status)
            {
                playerSymbol = "X";
            }

            somePanelButton.Text = playerSymbol;
            somePanelButton.Enabled = false;

            turn_status = !turn_status;

            if (turn_status)
            {
                turn_player_label.Text = "Turn player 2";
            }
            else
            {
                turn_player_label.Text = "Turn player 1";
            }

            return playerSymbol;
        }
    }
}
