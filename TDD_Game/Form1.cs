namespace TDD_Game
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        int turnCounter = 0;

        Button[,] buttons;
        public Form1()
        {
            InitializeComponent();

            buttons = new Button[3, 3]
            {
                { button11, button12, button13 },
                { button21, button22, button23 },
                { button31, button32, button33 }
            };
        }

        private void Start_Game_Button_Click(object sender, EventArgs e)
        {
            game.Start_Game(Start_Game_Button, buttons, turn_player_label);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button11, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9) { 
                game.End_Game(Start_Game_Button, buttons, turn_player_label); 
                turnCounter = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button12, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button13, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button21, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button22, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button23, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button31, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button32, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            game.Next_Turn(button33, turn_player_label);
            turnCounter++;
            if (game.Check_Win(buttons) || turnCounter >= 9)
            {
                game.End_Game(Start_Game_Button, buttons, turn_player_label);
                turnCounter = 0;
            }
        }
    }
}
