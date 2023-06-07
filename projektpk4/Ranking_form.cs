using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektpk4
{
    public partial class Ranking_form : Form
    {
        public Ranking_form()
        {
            InitializeComponent();
            textBox1.Text = Ranking_Controls.load_ranking();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
