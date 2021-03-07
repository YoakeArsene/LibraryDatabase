using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class EditTicket : Form
    {
        public EditTicket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");
        private void EditTicket_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                DateTime dateOut = DateTime.ParseExact(textBox6.Text, "dd/MM/yyyy", null);
                dateOut = Convert.ToDateTime(dateOut, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);

                DateTime dateIn = DateTime.ParseExact(textBox7.Text, "dd/MM/yyyy", null);
                dateIn = Convert.ToDateTime(dateIn, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);
                string query = "EXEC dbo.UpdateLoan " + textBox1.Text + ", " + "'" + textBox2.Text + "'" + ", " + "'" + textBox3.Text + "'" + ", " + "'" + textBox4.Text + "'" + ", " + "'" +
                               textBox5.Text + "'" + ", " + "'" + dateOut + "'" + "," + "'" + dateIn + "'" + "," + textBox8.Text;
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
                string query = "SELECT TicketId, Books.Title AS Title, Shelves.GenreName AS Genre, Borrowers.StudentName AS Student, Duration, DateOut, DateIn, Quantity FROM BookLoans INNER JOIN Books ON BookLoans.BookId = Books.BookId INNER JOIN Shelves ON BookLoans.ShelfId = Shelves.ShelfId INNER JOIN Borrowers ON BookLoans.StudentId = Borrowers.StudentId WHERE TicketId = " + "" + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Title"].ToString();
                    textBox3.Text = dr["Genre"].ToString();
                    textBox4.Text = dr["Student"].ToString();
                    textBox5.Text = dr["Duration"].ToString();
                    textBox6.Text = dr["DateOut"].ToString();
                    textBox7.Text = dr["DateIn"].ToString();
                    textBox8.Text = dr["Quantity"].ToString();
                }

                con.Close();


            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }

            if (!(textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty))
            {
                MessageBox.Show("Ticket ID doesn't exist!");
            }
        }


    }
}
