namespace projektpk4
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Start_Game = new Button();
            Ranking = new Button();
            End = new Button();
            SuspendLayout();
            // 
            // Start_Game
            // 
            Start_Game.Location = new Point(353, 64);
            Start_Game.Name = "Start_Game";
            Start_Game.Size = new Size(75, 23);
            Start_Game.TabIndex = 0;
            Start_Game.Text = "Start";
            Start_Game.UseVisualStyleBackColor = true;
            Start_Game.Click += Start_Game_Click;
            // 
            // Ranking
            // 
            Ranking.Location = new Point(353, 209);
            Ranking.Name = "Ranking";
            Ranking.Size = new Size(75, 23);
            Ranking.TabIndex = 1;
            Ranking.Text = "Ranking";
            Ranking.UseVisualStyleBackColor = true;
            Ranking.Click += Ranking_Click;
            // 
            // End
            // 
            End.Location = new Point(353, 357);
            End.Name = "End";
            End.Size = new Size(75, 23);
            End.TabIndex = 2;
            End.Text = "Exit";
            End.UseVisualStyleBackColor = true;
            End.Click += End_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(End);
            Controls.Add(Ranking);
            Controls.Add(Start_Game);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Start_Game;
        private Button Ranking;
        private Button End;
    }
}