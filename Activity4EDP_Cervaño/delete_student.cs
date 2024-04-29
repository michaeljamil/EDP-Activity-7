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
    public partial class delete_student : Form
    {
        connection con = new connection();
        public delete_student()
        {
            InitializeComponent();
        }

        private void delete_student_Load(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_ID.Text != "")
                {
                    // Open database connection
                    if (con.Open())
                    {
                        // Prepare INSERT query
                        string query = "DELETE from students WHERE student_id=@ID";

                        // Create MySqlCommand object using connection object
                        MySqlCommand cmd = con.CreateCommand(query);

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@ID", int.Parse(student_ID.Text));

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        // Close database connection
                        con.Close();

                        // Clear text boxes
                        student_ID.Text = "";
                      

                        // Display success message
                        MessageBox.Show("Successfully Deleted");
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
    }
}
