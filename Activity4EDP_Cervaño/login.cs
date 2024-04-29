using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    

namespace Activity4EDP_Cervaño
{
    public partial class loginForm : Form
    {
        connection con = new connection();
        string id, username, password;
        public loginForm()
        {
            InitializeComponent();
            passWord.UseSystemPasswordChar = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passWord.UseSystemPasswordChar = false;
            }
            else
            {
                passWord.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userName.Text != "" && passWord.Text != "")
                {
                    con.Open();
                    string query = "select admin_id,admin_name,admin_pass from administrator WHERE admin_name ='" + userName.Text + "' AND admin_pass ='" + passWord.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["admin_id"].ToString();
                            username = row["admin_name"].ToString();
                            password = row["admin_pass"].ToString();
                        }
                        MessageBox.Show("Login Successful");
                        dashboard newdb = new dashboard();
                        newdb.Show();
                        this.Hide();    
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newPassword forgotPasswordForm = new newPassword();

            forgotPasswordForm.Show();

            this.Hide();
        }
    }
}
