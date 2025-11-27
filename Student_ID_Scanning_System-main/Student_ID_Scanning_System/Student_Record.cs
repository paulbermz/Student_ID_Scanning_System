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
    public partial class Student_Record : Form
    {
        public static Student_Record Instance { get; private set; }
        public Student_Record()
        {
            InitializeComponent();
            Instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();    
            reports.Show();
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

                // Hide current form
                this.Hide();

                // Show login form
                Login login = new Login();
                login.Show();

            }
        }

    }
}
