using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {
                string query = "EXEC dbo.AddStudent " + "'" + textBox1.Text + "'" + ", " + "'" + textBox2.Text + "'" +
                               ", " + "'" + textBox3.Text + "'" + ", " + "'" + textBox4.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                MessageBox.Show(@"Add Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Please complete the form!");
            }
        }
    }
}
