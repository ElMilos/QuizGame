using System.Collections.Generic;

namespace projektpk4
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            Quiz.Next_Question();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void button1_Click(object sender, EventArgs e)
        {

            Quiz.Check(button1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Quiz.Check(button2.Text);
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            Quiz.Check(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz.Check(button4.Text);
        }




    }
}