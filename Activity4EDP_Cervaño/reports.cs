using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4EDP_Cervaño
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loginForm logoutForm1 = new loginForm();

            logoutForm1.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboardform = new dashboard();

            dashboardform.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            about aboutform = new about();

            aboutform.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            dashboard dashboardf = new dashboard(); 

            dashboardf.Show();  

            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            about aboutform1 = new about();

            aboutform1.Show();

            this.Hide();    
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            loginForm asdsds = new loginForm();

            asdsds.Show();

            this.Hide();
        }
    }
}
