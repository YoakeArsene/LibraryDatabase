using System;
using System.Windows.Forms;

namespace DatabaseAssignment
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students StudentForm = new Students();
            StudentForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library LibraryForm = new Library();
            LibraryForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loan LoanForm = new Loan();
            LoanForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
