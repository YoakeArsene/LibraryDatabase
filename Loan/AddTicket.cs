using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");

        private void AddTicket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty
                && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                DateTime dateOut = DateTime.ParseExact(textBox5.Text, "dd/MM/yyyy", null);
                dateOut = Convert.ToDateTime(dateOut, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);

                DateTime dateIn = DateTime.ParseExact(textBox6.Text, "dd/MM/yyyy", null);
                dateIn = Convert.ToDateTime(dateIn, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);

                string query = "EXEC dbo.AddLoan " + "'" + textBox1.Text + "'" + ", " + "'" + textBox2.Text + "'" + ", " + "'" + textBox3.Text + "'" + ", " + "'" + textBox4.Text + "'" + ", " + "'" +
                               dateOut + "'" + ", " + "'" + dateIn + "'" + ", " + textBox7.Text;
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
