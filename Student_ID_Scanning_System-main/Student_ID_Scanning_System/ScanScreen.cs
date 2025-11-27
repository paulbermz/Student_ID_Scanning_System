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
    public partial class Scan_Screen : Form
    {
        public static Scan_Screen Instance { get; private set; }

        private QR_Code qrInstance;
        public Scan_Screen()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Scan_Screen_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        //private void btnCamera_MouseHover(object sender, EventArgs e)
        //{
        //    btnCamera.ForeColor = Color.FromArgb(237, 241, 214);
        //}

        //private void btnCamera_MouseLeave(object sender, EventArgs e) 
        //{
        //    btnCamera.ForeColor = Color.FromArgb(96, 153, 102);
        //}

        private void btnQR_Click(object sender, EventArgs e)
        {
            qrInstance = new QR_Code();
            qrInstance.TopLevel = false;
            pBody.Controls.Add(qrInstance);
            qrInstance.BringToFront();
            qrInstance.Show();
            btnQR.ForeColor = Color.FromArgb(96, 153, 102);
            btnQR.BackColor = Color.FromArgb(237, 241, 214);
            btnQR.FlatAppearance.BorderColor = Color.FromArgb(96, 153, 102);
            btnQR.FlatAppearance.BorderSize = 2;
            btnBarcode.ForeColor = Color.FromArgb(237, 241, 214);
            btnBarcode.BackColor = Color.FromArgb(96, 153, 102);
            btnBarcode.FlatAppearance.BorderSize = 0;
            btnRFID.ForeColor = Color.FromArgb(237, 241, 214);
            btnRFID.BackColor = Color.FromArgb(96, 153, 102);
            btnRFID.FlatAppearance.BorderSize = 0;
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
            }

            Barcode barcode = new Barcode();
            barcode.TopLevel = false;
            pBody.Controls.Add(barcode);
            barcode.BringToFront();
            barcode.Show();
            btnBarcode.ForeColor = Color.FromArgb(96, 153, 102);
            btnBarcode.BackColor = Color.FromArgb(237, 241, 214);
            btnBarcode.FlatAppearance.BorderColor = Color.FromArgb(96, 153, 102);
            btnBarcode.FlatAppearance.BorderSize = 2;
            btnQR.ForeColor = Color.FromArgb(237, 241, 214);
            btnQR.BackColor = Color.FromArgb(96, 153, 102);
            btnQR.FlatAppearance.BorderSize = 0;
            btnRFID.ForeColor = Color.FromArgb(237, 241, 214);
            btnRFID.BackColor = Color.FromArgb(96, 153, 102);
            btnRFID.FlatAppearance.BorderSize = 0;
        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
            }

            RFID rfid = new RFID();
            rfid.TopLevel = false;
            pBody.Controls.Add(rfid);
            rfid.BringToFront();
            rfid.Show();
            btnRFID.ForeColor = Color.FromArgb(96, 153, 102);
            btnRFID.BackColor = Color.FromArgb(237, 241, 214);
            btnRFID.FlatAppearance.BorderColor = Color.FromArgb(96, 153, 102);
            btnRFID.FlatAppearance.BorderSize = 2;
            btnQR.ForeColor = Color.FromArgb(237, 241, 214);
            btnQR.BackColor = Color.FromArgb(96, 153, 102);
            btnQR.FlatAppearance.BorderSize = 2;
            btnBarcode.ForeColor = Color.FromArgb(237, 241, 214);
            btnBarcode.BackColor = Color.FromArgb(96, 153, 102);
            btnBarcode.FlatAppearance.BorderSize = 0;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
            }
            ;
            // Show Dashboard
            if (MainDashboard.Instance != null)
            {
                MainDashboard.Instance.Show();
                MainDashboard.Instance.BringToFront();
            }

            // Hide Scan_Screen
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

            // Show Dashboard
            if (MainDashboard.Instance != null)
            {
                MainDashboard.Instance.Show();
                MainDashboard.Instance.BringToFront();
            }

            // Hide Scan_Screen
            this.Hide();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
            }
            Student_Record studentRecord = new Student_Record();
            studentRecord.Show();
            this.Hide();
        }

        private void lblStudentRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
            }
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {

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

                // Hide current form
                this.Hide();

                // Show login form
                Login login = new Login();
                login.Show();

            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnScanID_Click(object sender, EventArgs e)
        {
            // safe close pattern
            if (qrInstance != null)
            {
                qrInstance.CloseCamera();
                // optionally dispose/hide and clear reference:
            }
        }
    }
}
