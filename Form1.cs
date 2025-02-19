using System.Reflection.Metadata.Ecma335;

namespace NayAGL_sp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentGPA.Clear();
            lstOutput.Items.Clear();
            txtStudentName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            txtStudentName.BackColor = Color.Bisque;
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            txtStudentName.BackColor = SystemColors.Window;
        }

        private void txtGPA_Enter(object sender, EventArgs e)
        {
            txtStudentGPA.BackColor = Color.Bisque;
        }

        private void txtGPA_Leave(object sender, EventArgs e)
        {
            txtStudentGPA.BackColor = SystemColors.Window;
        }
    }
}
