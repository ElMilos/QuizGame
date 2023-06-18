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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new Create_Player();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void Ranking_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new Ranking_form();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void End_Click(object sender, EventArgs e)
        {

            Ranking_Controls.save_Ranking();

            this.Close();
        }
    }
}
