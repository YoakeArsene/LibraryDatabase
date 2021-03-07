using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Assignment1_Library; Integrated Security = True");

        private void ViewButton_Click(object sender, EventArgs e)
        {
            GetLibraryData();
        }


        private void GetLibraryData()
        {
            SqlCommand cmd = new SqlCommand("EXEC dbo.ViewLibrary", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            LibraryGridView.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(LibraryGridView.SelectedCells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("Delete Book with ID " + i + "?", "Delete Book", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM Books WHERE BookId = " + i;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                GetLibraryData();
            }
            else
            {

            }

        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty)
            {
                string query = "EXEC dbo.SearchLibrary " + "'" + textBox1.Text + "'" + ", " + "'" + textBox2.Text + "'" +
                               ", " + "'" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                LibraryGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There's nothing to search!");
            }
        }

        private void LibraryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
