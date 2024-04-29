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
    public partial class Add_students : Form
    {
        connection con = new connection();
        public Add_students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_students_Load(object sender, EventArgs e)
        {

        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_name.Text != "" && student_email.Text != "" && student_address.Text != "" && student_contact.Text != "")
                {
                    // Open database connection
                    if (con.Open())
                    {
                        // Prepare INSERT query
                        string query = "INSERT INTO students (student_id, student_name, student_email, student_address, student_contact) VALUES (@ID, @Name, @Email, @Address, @Contact)";

                        // Create MySqlCommand object using connection object
                        MySqlCommand cmd = con.CreateCommand(query);

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@ID", int.Parse(student_ID.Text));
                        cmd.Parameters.AddWithValue("@Name", student_name.Text);
                        cmd.Parameters.AddWithValue("@Email", student_email.Text);
                        cmd.Parameters.AddWithValue("@Address", student_address.Text);
                        cmd.Parameters.AddWithValue("@Contact", student_contact.Text);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        // Close database connection
                        con.Close();

                        // Clear text boxes
                        student_ID.Text = "";
                        student_name.Text = "";
                        student_email.Text = "";
                        student_address.Text = "";
                        student_contact.Text = "";
                        // Display success message
                        MessageBox.Show("Successfully Inserted");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to open database connection.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failed: " + ex.Message);
            }
        }

        private void student_name_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
