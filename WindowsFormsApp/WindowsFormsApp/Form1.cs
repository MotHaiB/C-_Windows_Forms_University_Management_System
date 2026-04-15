using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideAllGroups();
        }
        private int selectedPersonID = -1;

        private void HideAllGroups()
        {
            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible = false;
        }

        private void SavePersonToDb(Person p)
        {
            string query = @"INSERT INTO People (FullName, Email, Telephone, UserRole, Salary, IsFullTime, WorkingHours, Subject1, Subject2, Subject3) 
                             VALUES (@name, @email, @phone, @role, @salary, @isFullTime, @hours, @s1, @s2, @s3)";

            using (SqlConnection conn = new SqlConnection(this.peopleTableAdapter.Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", p.FullName);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@phone", p.Telephone);
                cmd.Parameters.AddWithValue("@role", p.Role);
                p.MapSpecializedParameters(cmd);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{p.Role} added successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedRole = comboBox1.SelectedItem?.ToString() ?? "All";
            string query = "SELECT * FROM People";
            if (selectedRole != "All") query += " WHERE UserRole = @role";

            try
            {
                using (SqlConnection conn = new SqlConnection(this.peopleTableAdapter.Connection.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (selectedRole != "All") adapter.SelectCommand.Parameters.AddWithValue("@role", selectedRole);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedRole = comboBox1.SelectedItem?.ToString();
            HideAllGroups();
            switch (selectedRole)
            {
                case "Admin": groupBox1.Visible = true; groupBox1.Location = new Point(20, 150); break;
                case "Teacher": groupBox2.Visible = true; groupBox2.Location = new Point(20, 150); break;
                case "Student": groupBox3.Visible = true; groupBox3.Location = new Point(20, 150); break;
                default: MessageBox.Show("Select a role first!"); break;
            }
        }

        private void Admin_Done_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin
            {
                FullName = adminName.Text,
                Email = adminEmail.Text,
                Telephone = adminTelephone.Text,
                Salary = double.TryParse(adminSalary.Text, out double s) ? s : 0,
                WorkingHours = int.TryParse(i.Text, out int h) ? h : 0,
                IsFullTime = isFullTime.Checked
            };
            SavePersonToDb(adm);
            ClearAdminInputs();
            button1_Click(null, null);
        }

        private void tDone_Click(object sender, EventArgs e)
        {
            Teacher tea = new Teacher
            {
                FullName = teacherName.Text,
                Email = teacherEmail.Text,
                Telephone = teacherTelephone.Text,
                Salary = double.TryParse(teacherSalary.Text, out double s) ? s : 0,
                Subject1 = teacherSubject1.Text,
                Subject2 = teacherSubject2.Text
            };
            SavePersonToDb(tea);
            ClearTeacherInputs();
            button1_Click(null, null);
        }

        private void studentDone_Click(object sender, EventArgs e)
        {
            Student stu = new Student
            {
                FullName = studentName.Text,
                Email = studentEmail.Text,
                Telephone = studentTelephone.Text,
                Subject1 = studentSubject1.Text,
                Subject2 = studentSubject2.Text,
                Subject3 = studentSubject3.Text
            };
            SavePersonToDb(stu);
            ClearStudentInputs();
            button1_Click(null, null);
        }

        // --- PLACEHOLDERS FOR DESIGNER LINKS ---

        private void edit_Click(object sender, EventArgs e)
        {
            // Check if a row is actually selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 1. Get the selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // 2. Map the ID to our global variable for later saving
                selectedPersonID = Convert.ToInt32(row.Cells["ID"].Value);

                // 3. Load basic info (Common to all Persons)
                name.Text = row.Cells["FullName"].Value?.ToString();
                telephone.Text = row.Cells["Telephone"].Value?.ToString();
                email.Text = row.Cells["Email"].Value?.ToString();

                // 4. Load Specialized Data (Check if columns exist in the current grid view)

                if (dataGridView1.Columns.Contains("Salary"))
                    salary.Text = row.Cells["Salary"].Value?.ToString();

                if (dataGridView1.Columns.Contains("Subject1"))
                    subject1.Text = row.Cells["Subject1"].Value?.ToString();

                if (dataGridView1.Columns.Contains("Subject2"))
                    subject2.Text = row.Cells["Subject2"].Value?.ToString();

                if (dataGridView1.Columns.Contains("Subject3"))
                    subject3.Text = row.Cells["Subject3"].Value?.ToString();

                // Admin Specific: IsFullTime
                if (dataGridView1.Columns.Contains("IsFullTime"))
                {
                    // Handle null or DBNull safely
                    var cellValue = row.Cells["IsFullTime"].Value;
                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        bool isFull = Convert.ToBoolean(cellValue);
                        comboBox2.Text = isFull ? "Full Time" : "Not Full Time";
                    }
                }

                MessageBox.Show("Press Save to keep the changes.", "Notice");
            }
            else
            {
                MessageBox.Show("Please select a row in the list first!", "Selection Required");
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            // If no ID is selected, we don't know who to update
            if (selectedPersonID == -1)
            {
                MessageBox.Show("Please select and 'Edit' a person first!");
                return;
            }

            string query = @"UPDATE People SET 
                        FullName = @name, Telephone = @phone, Email = @email, 
                        Salary = @salary, Subject1 = @s1, Subject2 = @s2, Subject3 = @s3,
                        IsFullTime = @isFull 
                    WHERE ID = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(this.peopleTableAdapter.Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedPersonID);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@phone", telephone.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);

                    // Handle numeric salary safely
                    double.TryParse(salary.Text, out double sal);
                    cmd.Parameters.AddWithValue("@salary", sal);

                    // Handle subjects
                    cmd.Parameters.AddWithValue("@s1", string.IsNullOrEmpty(subject1.Text) ? (object)DBNull.Value : subject1.Text);
                    cmd.Parameters.AddWithValue("@s2", string.IsNullOrEmpty(subject2.Text) ? (object)DBNull.Value : subject2.Text);
                    cmd.Parameters.AddWithValue("@s3", string.IsNullOrEmpty(subject3.Text) ? (object)DBNull.Value : subject3.Text);

                    // Admin Logic: IsFullTime ComboBox
                    cmd.Parameters.AddWithValue("@isFull", comboBox2.Text == "Full Time" ? 1 : 0);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Successful!", "Success");

                    // Reset ID and refresh list
                    selectedPersonID = -1;
                    _cancel_Click(null, null); // Clear textboxes
                    button1_Click(null, null); // Refresh DataGridView
                }
            }
            catch (Exception ex) { MessageBox.Show("Error updating: " + ex.Message); }
        }

        private void _cancel_Click(object sender, EventArgs e)
        {

            name.Clear();
            telephone.Clear();
            email.Clear();
            salary.Clear();
            subject1.Clear();
            subject2.Clear();
            subject3.Clear();

            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = -1;

            selectedPersonID = -1;

        }
        private void delete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string personName = dataGridView1.SelectedRows[0].Cells["FullName"].Value?.ToString();

                // Always ask for confirmation before deleting!
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete {personName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM People WHERE ID = @id";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(this.peopleTableAdapter.Connection.ConnectionString))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", idToDelete);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted successfully.");
                            button1_Click(null, null); // Refresh list
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error deleting: " + ex.Message); }
                }
            }
            else
            {
                MessageBox.Show("Please select a full row to delete.");
            }
        }
        private void save_and_exit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void Cancel_Click(object sender, EventArgs e) { ClearAdminInputs(); }
        private void tCancel_Click(object sender, EventArgs e) { ClearTeacherInputs(); }
        private void studentCancel_Click(object sender, EventArgs e) { ClearStudentInputs(); }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void ClearAdminInputs() { adminName.Clear(); adminEmail.Clear(); adminTelephone.Clear(); adminSalary.Clear(); workingHours.Clear(); HideAllGroups(); }
        private void ClearTeacherInputs() { teacherName.Clear(); teacherEmail.Clear(); teacherTelephone.Clear(); teacherSalary.Clear(); teacherSubject1.Clear(); teacherSubject2.Clear(); HideAllGroups(); }
        private void ClearStudentInputs() { studentName.Clear(); studentEmail.Clear(); studentTelephone.Clear(); studentSubject1.Clear(); studentSubject2.Clear(); studentSubject3.Clear(); HideAllGroups(); }
    }
    // OOP
    public abstract class Person // Base class for Polymorphism
    {
        public int ID { get; set; } // Database primary key
        public string FullName { get; set; } // Create get/set methods
        public string Email { get; set; } // Create get/set methods
        public string Telephone { get; set; } // Create get/set methods
        public string Role { get; protected set; } // Create get/set methods
        public abstract void MapSpecializedParameters(SqlCommand cmd);
    }

    public class Admin : Person
    {
        public double Salary { get; set; } // Create get/set methods
        public bool IsFullTime { get; set; } // Create get/set methods
        public int WorkingHours { get; set; } // Create get/set methods
        public Admin() => Role = "Admin";
        public override void MapSpecializedParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.Parameters.AddWithValue("@isFullTime", IsFullTime ? 1 : 0);
            cmd.Parameters.AddWithValue("@hours", WorkingHours);
            cmd.Parameters.AddWithValue("@s1", DBNull.Value);
            cmd.Parameters.AddWithValue("@s2", DBNull.Value);
            cmd.Parameters.AddWithValue("@s3", DBNull.Value);
        }
    }

    public class Teacher : Person
    {
        public double Salary { get; set; } // Create get/set methods
        public string Subject1 { get; set; } // Create get/set methods
        public string Subject2 { get; set; } // Create get/set methods
        public Teacher() => Role = "Teacher";
        public override void MapSpecializedParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.Parameters.AddWithValue("@isFullTime", DBNull.Value);
            cmd.Parameters.AddWithValue("@hours", DBNull.Value);
            cmd.Parameters.AddWithValue("@s1", Subject1 ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@s2", Subject2 ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@s3", DBNull.Value);
        }
    }

    public class Student : Person
    {
        public string Subject1 { get; set; } // Create get/set methods
        public string Subject2 { get; set; } // Create get/set methods
        public string Subject3 { get; set; } // Create get/set methods
        public Student() => Role = "Student";
        public override void MapSpecializedParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@salary", 0);
            cmd.Parameters.AddWithValue("@isFullTime", DBNull.Value);
            cmd.Parameters.AddWithValue("@hours", DBNull.Value);
            cmd.Parameters.AddWithValue("@s1", Subject1 ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@s2", Subject2 ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@s3", Subject3 ?? (object)DBNull.Value);
        }
    }


}