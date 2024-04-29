using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;



namespace Activity4EDP_Cervaño
{
    public partial class management : Form
    {
        connection con = new connection();
        public management()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stud_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void stud_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void management_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM students";
            MySqlCommand cmd = con.CreateCommand(query);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void stud_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Add_students insert = new Add_students();
            insert.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            update_students update = new update_students();
            update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_student deleting = new delete_student();
            deleting.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM students WHERE student_name=@Name";
            MySqlCommand cmd = con.CreateCommand(query);

            cmd.Parameters.AddWithValue("@Name", stud_Name.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM students";
            MySqlCommand cmd = con.CreateCommand(query);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void browse_File_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtFilename.Text = ofd.FileName;

            }

        }

        void generate_report_Click(object sender, EventArgs e)
        {
            // Step 1: Load the empty Excel template
            if (string.IsNullOrEmpty(txtFilename.Text))
            {
                MessageBox.Show("Please Select your template file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var workbook = new XLWorkbook(txtFilename.Text);

            // Report 1: List of Students
            DataTable studentList = new DataTable();
            studentList.Columns.Add("Student ID");
            studentList.Columns.Add("Student Name");
            studentList.Columns.Add("Email");
            studentList.Columns.Add("Address");
            studentList.Columns.Add("Contact");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow newRow = studentList.NewRow();
                newRow["Student ID"] = row.Cells["student_ID"].Value ?? DBNull.Value;
                newRow["Student Name"] = row.Cells["student_name"].Value ?? DBNull.Value;
                newRow["Email"] = row.Cells["student_email"].Value ?? DBNull.Value;
                newRow["Address"] = row.Cells["student_address"].Value ?? DBNull.Value;
                newRow["Contact"] = row.Cells["student_contact"].Value ?? DBNull.Value;
                studentList.Rows.Add(newRow);
            }

            var studentListWorksheet = workbook.Worksheet("Student List");
            if (studentListWorksheet == null)
            {
                studentListWorksheet = workbook.Worksheets.Add("Student List");
            }
            studentListWorksheet.Cell(5, 1).InsertTable(studentList); // Start from row 5 for the list of students

            // Report 2: Email Domains Report
            DataTable emailDomains = new DataTable();
            emailDomains.Columns.Add("Email Domain");
            emailDomains.Columns.Add("Count");

            Dictionary<string, int> domainCounts = new Dictionary<string, int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object value = row.Cells["student_email"].Value;
                if (value != null)
                {
                    string email = value.ToString();
                    string domain = email.Substring(email.IndexOf('@') + 1); // Extract domain part
                    if (domainCounts.ContainsKey(domain))
                    {
                        domainCounts[domain]++;
                    }
                    else
                    {
                        domainCounts[domain] = 1;
                    }
                }
            }

            foreach (var entry in domainCounts)
            {
                emailDomains.Rows.Add(entry.Key, entry.Value);
            }

            var emailDomainsWorksheet = workbook.Worksheet("Email Domains");
            if (emailDomainsWorksheet == null)
            {
                emailDomainsWorksheet = workbook.Worksheets.Add("Email Domains");
            }
            emailDomainsWorksheet.Cell(5, 1).InsertTable(emailDomains); // Start from row 5 for the Email Domains Report

            // Report 3: Address Analysis Report
            DataTable addressAnalysis = new DataTable();
            addressAnalysis.Columns.Add("Town");
            addressAnalysis.Columns.Add("Province");
            addressAnalysis.Columns.Add("Count");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object value = row.Cells["student_address"].Value;
                if (value != null)
                {
                    string address = value.ToString();
                    string[] addressParts = address.Split(',');
                    if (addressParts.Length >= 2)
                    {
                        string town = addressParts[0].Trim();
                        string province = addressParts[1].Trim();
                        int count = 1;
                        if (addressAnalysis.AsEnumerable().Any(r => r.Field<string>("Town") == town && r.Field<string>("Province") == province))
                        {
                            int.TryParse(addressAnalysis.AsEnumerable().First(r => r.Field<string>("Town") == town && r.Field<string>("Province") == province).Field<string>("Count"), out count);
                            count++;
                            addressAnalysis.Rows.Remove(addressAnalysis.AsEnumerable().First(r => r.Field<string>("Town") == town && r.Field<string>("Province") == province));
                        }
                        addressAnalysis.Rows.Add(town, province, count);
                    }
                }
            }

            var addressAnalysisWorksheet = workbook.Worksheet("Address Analysis");
            if (addressAnalysisWorksheet == null)
            {
                addressAnalysisWorksheet = workbook.Worksheets.Add("Address Analysis");
            }
            addressAnalysisWorksheet.Cell(5, 1).InsertTable(addressAnalysis); // Start from row 5 for the Address Analysis Report

            // Step 5: Save the workbook to the specified file path, overwriting the template
            try
            {
                workbook.Save();
                MessageBox.Show("Reports generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
    }
