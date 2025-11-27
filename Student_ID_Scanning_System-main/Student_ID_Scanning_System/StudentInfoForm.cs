using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Student_ID_Scanning_System
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        // Set student text data
        public void SetStudentData(string id, string name, string program, string year, string section, string status, string email, string phone, string address)
        {
            lblID.Text = id;
            lblName.Text = name;
            lblProgram.Text = program;
            lblYear.Text = year;
            lblSection.Text = section;
            lblStatus.Text = status;
            lblEmail.Text = email;
            lblPhone.Text = phone;
            lblAddress.Text = address;
        }

        public void SetStudentImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    if (studentPicture.Image != null)
                    {
                        studentPicture.Image.Dispose();
                    }

                    studentPicture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image not found at: " + imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
    }
}