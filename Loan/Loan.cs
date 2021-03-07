using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            GetLoanData();
        }

        private void GetLoanData()
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.ViewLoans", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty)
            {
                string query = "EXEC dbo.SearchLoan " + "'" + textBox1.Text + "'" + ", " + "'" + textBox2.Text + "'" +
                               ", " + "'" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("Delete Ticket with ID " + i + "?", "Delete Ticket", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM BookLoans WHERE TicketId = " + i;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                GetLoanData();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditTicket editTicket = new EditTicket();
            editTicket.Show();
        }
    }
}
