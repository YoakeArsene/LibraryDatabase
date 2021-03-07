using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");
        private void EditBook_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string query = "SELECT BookId, BookAuthors.AuthorName AS Author, Shelves.GenreName AS Genre, Title, Origin, Status, NumberOfCopies FROM Books INNER JOIN BookAuthors ON Books.AuthorId = BookAuthors.AuthorId "
                + "INNER JOIN Shelves ON Books.ShelfId = Shelves.ShelfId WHERE BookId = " + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Title"].ToString();
                    textBox3.Text = dr["Author"].ToString();
                    textBox4.Text = dr["Genre"].ToString();
                    textBox5.Text = dr["Origin"].ToString();
                    textBox6.Text = dr["Status"].ToString();
                    textBox7.Text = dr["NumberOfCopies"].ToString();
                }

                con.Close();


            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }

            if (!(textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty))
            {
                MessageBox.Show("Book ID doesn't exist!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                string query = "EXEC dbo.UpdateBook " + textBox1.Text + ", " + "'" + textBox2.Text + "'" + ", " + "'" + textBox3.Text + "'" + ", " + "'" + textBox4.Text + "'" + ", " + "'" +
                               textBox5.Text + "'" + ", " + "'" + textBox6.Text + "'" + "," + textBox7.Text;
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
    }
}
