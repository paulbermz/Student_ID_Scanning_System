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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void btnScanID_Click(object sender, EventArgs e)
        {
            Scan_Screen scanScreen = new Scan_Screen();
            scanScreen.Show();
            this.Hide();
        }

        private void lblStudentRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            Student_Record studentRecord = new Student_Record();
            studentRecord.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }
        private void ConfirmLogout()
        {
            DialogResult result = MessageBox.Show(
                   "Are you sure you want to logout?",
                   "Logout Confirmation",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

            if (result == DialogResult.Yes)
            {
                // Close other forms manually
                if (MainDashboard.Instance != null)
                    MainDashboard.Instance.Close();

                if (Scan_Screen.Instance != null)
                    Scan_Screen.Instance.Close();

                if(Student_Record.Instance != null)
                    Student_Record.Instance.Close();
                // Hide current form
                this.Hide();

                // Show login form
                Login login = new Login();
                login.Show();

            }
        }
    }
}
