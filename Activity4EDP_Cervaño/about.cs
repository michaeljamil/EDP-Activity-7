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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboardform = new dashboard();

            dashboardform.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reports form1 = new reports();

            form1.Show();

            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loginForm logoutForm1 = new loginForm();

            logoutForm1.Show();

            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            dashboard dashboardform = new dashboard();

            dashboardform.Show();

            this.Hide();   
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            loginForm form32 = new loginForm();

            form32.Show();

            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            reports reportsform1 = new reports();

            reportsform1.Show();    

            this.Hide();    
        }
    }
}
