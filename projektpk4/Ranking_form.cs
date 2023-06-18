using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace projektpk4
{
    public partial class Ranking_form : Form
    {
        public Ranking_form()
        {
            InitializeComponent();
            Ranking_Controls hold = new Ranking_Controls();
            textBox1.Text = hold.Show_List();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new menu();

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;

            form1.Closed += (s, args) => this.Close();
            form1.Show();


        }
    }
}
