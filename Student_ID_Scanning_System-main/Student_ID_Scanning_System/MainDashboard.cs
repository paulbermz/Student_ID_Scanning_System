using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Student_ID_Scanning_System
{
    public partial class MainDashboard : Form
    {

        public static MainDashboard Instance { get; private set; }
        public MainDashboard()
        {
            InitializeComponent();
            Instance = this;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
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


        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnScanID_Click(object sender, EventArgs e)
        {
            if (Scan_Screen.Instance == null || Scan_Screen.Instance.IsDisposed)
            {
                Scan_Screen scan = new Scan_Screen();
                scan.Show();
            }
            else
            {
                Scan_Screen.Instance.Show();
                Scan_Screen.Instance.BringToFront();
            }

            this.Hide(); // Hide Dashboard while Scan

        }

        private void lblScanID_Click(object sender, EventArgs e)
        {
            if (Scan_Screen.Instance == null || Scan_Screen.Instance.IsDisposed)
            {
                Scan_Screen scan = new Scan_Screen();
                scan.Show();
            }
            else
            {
                Scan_Screen.Instance.Show();
                Scan_Screen.Instance.BringToFront();
            }

            this.Hide(); // Hide Dashboard while Scan
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Scan_Screen scan = new Scan_Screen();
            scan.ShowDialog();

        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            Scan_Screen scan = new Scan_Screen();
            scan.ShowDialog();

        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            Scan_Screen scan = new Scan_Screen();
            scan.ShowDialog();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            Student_Record studentRecord = new Student_Record();
            studentRecord.ShowDialog();
            this.Hide();
        }

        private void lblStudentRecord_Click(object sender, EventArgs e)
        {
            Student_Record studentRecord = new Student_Record();
            studentRecord.ShowDialog();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Hide();
        }
    }
}
