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
    public partial class Create_Player : Form
    {
        public Create_Player()
        {
            InitializeComponent();
        }

        private void Start_Quiz_Click(object sender, EventArgs e)
        {

            if (Player_name.Text != "")
            {
                Gracz gracz= new Gracz(Player_name.Text);

               // MessageBox.Show(gracz.nazwa); 
                this.Hide();

                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void Player_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
