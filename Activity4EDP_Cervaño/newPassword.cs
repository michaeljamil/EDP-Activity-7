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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Activity4EDP_Cervaño
{
    public partial class newPassword : Form
    {
        connection con = new connection();
        public newPassword()
        {
            InitializeComponent();
            newPass.UseSystemPasswordChar = true;
            connewPass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginForm form3 = new loginForm();

            form3.Show();

            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Text != "" && newPass.Text != "" && connewPass.Text != "")
                {
                    string newPassword = newPass.Text;
                    string confirmNewPassWord = connewPass.Text;
                    if (newPassword != confirmNewPassWord)
                    {
                        MessageBox.Show("Passwords do not match!");
                        return;
                    }

                    // Open the connection
                    if (con.Open())
                    {
                        // Prepare the query to fetch admin_id based on admin_name
                        string query = "SELECT admin_id FROM administrator WHERE admin_name = @username";
                        MySqlCommand cmd = con.CreateCommand(query);
                        cmd.Parameters.AddWithValue("@username", user.Text);

                        // Execute the query
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Get the admin_id
                            string id = reader["admin_id"].ToString();
                            reader.Close();

                            // Update the password
                            string updateQuery = "UPDATE administrator SET admin_pass = @newPassword WHERE admin_id = @id";
                            MySqlCommand updateCmd = con.CreateCommand(updateQuery);
                            updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                            updateCmd.Parameters.AddWithValue("@id", id);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }

                        // Close the connection
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the database!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                newPass.UseSystemPasswordChar = false;
                connewPass.UseSystemPasswordChar = false;
            }
            else
            {
                newPass.UseSystemPasswordChar = true;
                connewPass.UseSystemPasswordChar = true;
            }
        }

        private void newPassword_Load(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
