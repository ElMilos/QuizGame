namespace projektpk4
{
    partial class Quiz_Form
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Pytanie_Form = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(115, 223);
            button1.Name = "button1";
            button1.Size = new Size(145, 66);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(489, 223);
            button2.Name = "button2";
            button2.Size = new Size(145, 66);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(115, 353);
            button3.Name = "button3";
            button3.Size = new Size(145, 66);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(489, 353);
            button4.Name = "button4";
            button4.Size = new Size(145, 66);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Pytanie_Form
            // 
            Pytanie_Form.Anchor = AnchorStyles.None;
            Pytanie_Form.AutoSize = true;
            Pytanie_Form.BackColor = SystemColors.Info;
            Pytanie_Form.BorderStyle = BorderStyle.FixedSingle;
            Pytanie_Form.FlatStyle = FlatStyle.Flat;
            Pytanie_Form.Location = new Point(279, 108);
            Pytanie_Form.Name = "Pytanie_Form";
            Pytanie_Form.Size = new Size(214, 17);
            Pytanie_Form.TabIndex = 4;
            Pytanie_Form.Text = "TUtaj znajude sie bardzo dlugie pytanie";
            Pytanie_Form.Click += Pytanie_Form_Click;
            // 
            // Quiz_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(Pytanie_Form);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Quiz_Form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        static private Button button1;
        static private Button button2;
        static private Button button3;
        static private Button button4;
        static private Label Pytanie_Form;

        #endregion


        // get'ery i set'ery
        static public string Button1
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        static public string Button2
        { get { return button2.Text; } set { button2.Text = value; } }

        static public string Button3
        { get { return button3.Text; } set { button3.Text = value; } }

        static public string Button4
        { get { return button4.Text; } set { button4.Text = value; } }

        static public string pytanie_form
        { get { return Pytanie_Form.Text; } set { Pytanie_Form.Text = value; } }
    }
}