using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            if (username.Equals("arunsats.005") && password.Equals("christ@123"))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
