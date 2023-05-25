namespace projektpk4
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void button1_Click(object sender, EventArgs e)
        {
           string a =Quiz_Controls.Quiz_Cont();
            button4.Text = a;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button4.Text = "button2";
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            button4.Text = "button3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "button4";
        }




    }
}