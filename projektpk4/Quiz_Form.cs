using System.Collections.Generic;

namespace projektpk4
{
    public partial class Quiz_Form : Form
    {

        public Quiz_Form()
        {
            InitializeComponent();
            Quiz.Next_Question();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Quiz.Check(button1.Text))
            {
                this.Hide();
                var form1 = new menu();
                form1.StartPosition = FormStartPosition.Manual;
                form1.Location = this.Location;
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (!Quiz.Check(button2.Text))
            {
                this.Hide();
                var form1 = new menu();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!Quiz.Check(button3.Text))
            {
                this.Hide();
                var form1 = new menu();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!Quiz.Check(button4.Text))
            {
                this.Hide();
                var form1 = new menu();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void Pytanie_Form_Click(object sender, EventArgs e)
        {

        }
    }
}