namespace TDD_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            turn_player_label = new Label();
            Start_Game_Button = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            SuspendLayout();
            // 
            // turn_player_label
            // 
            turn_player_label.AutoSize = true;
            turn_player_label.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            turn_player_label.Location = new Point(84, 24);
            turn_player_label.Name = "turn_player_label";
            turn_player_label.Size = new Size(185, 37);
            turn_player_label.TabIndex = 0;
            turn_player_label.Text = "Turn player 1";
            turn_player_label.Visible = false;
            // 
            // Start_Game_Button
            // 
            Start_Game_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start_Game_Button.Location = new Point(41, 158);
            Start_Game_Button.Name = "Start_Game_Button";
            Start_Game_Button.Size = new Size(257, 57);
            Start_Game_Button.TabIndex = 1;
            Start_Game_Button.Text = "Start Game";
            Start_Game_Button.UseVisualStyleBackColor = true;
            Start_Game_Button.Click += Start_Game_Button_Click;
            // 
            // button11
            // 
            button11.Location = new Point(12, 84);
            button11.Name = "button11";
            button11.Size = new Size(100, 100);
            button11.TabIndex = 2;
            button11.UseVisualStyleBackColor = true;
            button11.Visible = false;
            // 
            // button12
            // 
            button12.Location = new Point(118, 84);
            button12.Name = "button12";
            button12.Size = new Size(100, 100);
            button12.TabIndex = 3;
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            // 
            // button13
            // 
            button13.Location = new Point(224, 84);
            button13.Name = "button13";
            button13.Size = new Size(100, 100);
            button13.TabIndex = 4;
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            // 
            // button21
            // 
            button21.Location = new Point(12, 190);
            button21.Name = "button21";
            button21.Size = new Size(100, 100);
            button21.TabIndex = 5;
            button21.UseVisualStyleBackColor = true;
            button21.Visible = false;
            // 
            // button22
            // 
            button22.Location = new Point(118, 190);
            button22.Name = "button22";
            button22.Size = new Size(100, 100);
            button22.TabIndex = 6;
            button22.UseVisualStyleBackColor = true;
            button22.Visible = false;
            // 
            // button23
            // 
            button23.Location = new Point(224, 190);
            button23.Name = "button23";
            button23.Size = new Size(100, 100);
            button23.TabIndex = 7;
            button23.UseVisualStyleBackColor = true;
            button23.Visible = false;
            // 
            // button31
            // 
            button31.Location = new Point(12, 296);
            button31.Name = "button31";
            button31.Size = new Size(100, 100);
            button31.TabIndex = 8;
            button31.UseVisualStyleBackColor = true;
            button31.Visible = false;
            // 
            // button32
            // 
            button32.Location = new Point(118, 296);
            button32.Name = "button32";
            button32.Size = new Size(100, 100);
            button32.TabIndex = 9;
            button32.UseVisualStyleBackColor = true;
            button32.Visible = false;
            // 
            // button33
            // 
            button33.Location = new Point(224, 296);
            button33.Name = "button33";
            button33.Size = new Size(100, 100);
            button33.TabIndex = 10;
            button33.UseVisualStyleBackColor = true;
            button33.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 421);
            Controls.Add(button33);
            Controls.Add(button32);
            Controls.Add(button31);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(Start_Game_Button);
            Controls.Add(turn_player_label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label turn_player_label;
        private Button Start_Game_Button;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button31;
        private Button button32;
        private Button button33;
    }
}
