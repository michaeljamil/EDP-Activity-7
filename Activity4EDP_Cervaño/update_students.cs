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
    public partial class update_students : Form
    {
        connection con = new connection();
        public update_students()
        {
            InitializeComponent();
        }

        private void update_students_Load(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (update_Selection.Text != "" && update_Box.Text != "" && student_ID.Text != "")
                {
                    // Prepare UPDATE query
                    string query = "UPDATE students SET ";

                    // Determine which field to update based on the ComboBox selection
                    switch (update_Selection.Text)
                    {
                        case "Student Name":
                            query += "student_name=@Name";
                            break;
                        case "Student Email":
                            query += "student_email=@Email";
                            break;
                        case "Student Address":
                            query += "student_address=@Address";
                            break;
                        case "Student Contact No.":
                            query += "student_contact=@Contact";
                            break;
                        default:
                            MessageBox.Show("Invalid selection.");
                            return;
                    }

                    query += " WHERE student_id=@ID";

                    // Create connection object
                    connection con = new connection();

                    // Open database connection
                    if (con.Open())
                    {
                        // Create MySqlCommand object
                        MySqlCommand cmd = con.CreateCommand(query);

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@ID", student_ID.Text);
                        cmd.Parameters.AddWithValue("@Name", update_Box.Text);
                        cmd.Parameters.AddWithValue("@Email", update_Box.Text);
                        cmd.Parameters.AddWithValue("@Address", update_Box.Text);
                        cmd.Parameters.AddWithValue("@Contact", update_Box.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        // Close database connection
                        con.Close();

                        // Clear text boxes
                        student_ID.Text = "";
                        update_Selection.Text = "";
                        update_Box.Text = "";

                        // Display success message
                        MessageBox.Show("Successfully Updated");
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
                MessageBox.Show("Update Failed: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
