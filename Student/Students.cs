using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                string query = "EXEC dbo.SearchStudent " + "'" + textBox1.Text + "'" + ", " + "'" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                StudentGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            GetStudentData();
        }

        private void GetStudentData()
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.ViewStudent", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            StudentGridView.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(StudentGridView.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("Delete Student with ID " + i + "?", "Delete Student", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM Borrowers WHERE StudentId = " + i;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                GetStudentData();
            }
            else
            {

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }
    }
}
