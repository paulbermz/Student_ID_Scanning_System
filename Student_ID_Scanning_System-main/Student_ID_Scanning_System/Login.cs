using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_ID_Scanning_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();  
            dashboard.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string defaultUser = "admin";
            string defaultPass = "admin123";

            // CHECK IF FIELDS ARE EMPTY
            if (username == "" && password == "")
            {
                MessageBox.Show("Please enter your username and password.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "")
            {
                MessageBox.Show("Please enter your username.",
                    "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter your password.",
                    "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDATE USERNAME & PASSWORD
            if (username == defaultUser && password == defaultPass)
            {
                MessageBox.Show("Login successful! Welcome, Admin.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Main Dashboard
                MainDashboard dashboard = new MainDashboard();
                dashboard.Show();

                // Hide the login form
                this.Hide();

                // Close login when dashboard closes
                dashboard.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text != "Password" && txtPassword.Text != "")
            {
                btnShow.BringToFront();
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
            }
            else
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" && txtPassword.Text != "")
            {
                btnHide.BringToFront();
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Location = new Point(1086, 282);
            if(txtPassword.Text == "")
            {
                lblPassword.Location = new Point(1086, 414);
            }

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            lblPassword.Location = new Point(1086, 400);
            if(txtUsername.Text == "")
            {
                lblUsername.Location = new Point(1086, 298);
            }
        }
    }
}
