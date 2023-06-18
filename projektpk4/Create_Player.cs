using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

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

            if (!string.IsNullOrWhiteSpace(Player_name.Text)) // sprawdzić czy nie jest puste
            {
                Quiz.send_name(Player_name.Text);

                this.Hide();
                var form1 = new Quiz_Form();
                form1.StartPosition = FormStartPosition.Manual;
                form1.Location = this.Location;
                form1.Closed += (s, args) => this.Close();
                form1.Show();


            }
            else MessageBox.Show("Nazwa nie moze być pusta");


        }

        private void Player_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
