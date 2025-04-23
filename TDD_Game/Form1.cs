namespace TDD_Game
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Game_Button_Click(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[3, 3]
            {
                { button11, button12, button13 },
                { button21, button22, button23 },
                { button31, button32, button33 }
            };

            game.Start_Game(Start_Game_Button, buttons, turn_player_label);
        }
    }
}
