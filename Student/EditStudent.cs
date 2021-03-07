using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty)
            {
                string query = "EXEC dbo.UpdateStudent " + textBox1.Text + ", " + "'" + textBox2.Text + "'" + ", " + "'" + textBox3.Text + "'" + ", " + "'" + textBox4.Text + "'" + ", " + "'" +
                               textBox5.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                MessageBox.Show("Update successfully!");
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("There's nothing to update!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string query = "SELECT StudentId, StudentName, Class, StudentAddress, PhoneNumber FROM Borrowers WHERE StudentId = " + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["StudentName"].ToString();
                    textBox3.Text = dr["Class"].ToString();
                    textBox4.Text = dr["StudentAddress"].ToString();
                    textBox5.Text = dr["PhoneNumber"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }

            if (!(textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty))
            {
                MessageBox.Show("Book ID doesn't exist!");
            }
        }
    }
}
