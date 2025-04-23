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

        public bool Check_Win(Button[,] buttons)
        {
            string currentSymbol = turn_status ? "0" : "X";

            // Проверка строк
            for (int row = 0; row < 3; row++)
            {
                if (buttons[row, 0].Text == currentSymbol &&
                    buttons[row, 1].Text == currentSymbol &&
                    buttons[row, 2].Text == currentSymbol)
                {
                    return true;
                }
            }

            // Проверка столбцов
            for (int col = 0; col < 3; col++)
            {
                if (buttons[0, col].Text == currentSymbol &&
                    buttons[1, col].Text == currentSymbol &&
                    buttons[2, col].Text == currentSymbol)
                {
                    return true;
                }
            }

            // Проверка главной диагонали
            if (buttons[0, 0].Text == currentSymbol &&
                buttons[1, 1].Text == currentSymbol &&
                buttons[2, 2].Text == currentSymbol)
            {
                return true;
            }

            // Проверка побочной диагонали
            if (buttons[0, 2].Text == currentSymbol &&
                buttons[1, 1].Text == currentSymbol &&
                buttons[2, 0].Text == currentSymbol)
            {
                return true;
            }

            return false;
        }

        public void End_Game(
                Button startGameButton,
                Button[,] buttons,
                Label turn_player)
        {
            startGameButton.Visible = true;
            foreach (Button button in buttons)
            {
                button.Visible = false;
                button.Text = "";
                button.Enabled = true;
            }
            if (!turn_status) { turn_player.Text = "Player 2 is Win"; }
            else { turn_player.Text = "Player 1 is Win"; }
            turn_status = false;
        }
    }
}
