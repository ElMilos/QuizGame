namespace projektpk4
{
    partial class Create_Player
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
            Start_Quiz = new Button();
            Player_name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Start_Quiz
            // 
            Start_Quiz.Location = new Point(359, 342);
            Start_Quiz.Name = "Start_Quiz";
            Start_Quiz.Size = new Size(75, 23);
            Start_Quiz.TabIndex = 0;
            Start_Quiz.Text = "Graj";
            Start_Quiz.UseVisualStyleBackColor = true;
            Start_Quiz.Click += Start_Quiz_Click;
            // 
            // Player_name
            // 
            Player_name.Location = new Point(283, 172);
            Player_name.Name = "Player_name";
            Player_name.Size = new Size(228, 23);
            Player_name.TabIndex = 1;
            Player_name.TextChanged += Player_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 69);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Podaj Nazwe";
            // 
            // Create_Player
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Player_name);
            Controls.Add(Start_Quiz);
            Name = "Create_Player";
            Text = "Create_Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start_Quiz;
        private TextBox Player_name;
        private Label label1;
    }
}