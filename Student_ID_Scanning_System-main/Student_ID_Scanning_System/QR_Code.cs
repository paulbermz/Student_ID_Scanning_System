using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MySqlConnector;
using ZXing;

namespace Student_ID_Scanning_System
{
    public partial class QR_Code : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public QR_Code()
        {
            InitializeComponent();
        }

        private void txtManualInput_Click(object sender, EventArgs e)
        {
            lblIDManual.Dispose();
        }

        // Function to open the camera
        private void btnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result =
                    MessageBox.Show("This feature requires access to your camera.\n\nDo you want to allow camera access?",
                    "Camera Access Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if(result == DialogResult.No)
                {
                    return;
                }

                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No camera detected.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                videoSource.Start();

                MessageBox.Show("Camera started successfully.", "Camera Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to display camera in UI
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Safely update UI from camera thread
                if (pictureBoxCamera.InvokeRequired)
                {
                    pictureBoxCamera.Invoke(new MethodInvoker(delegate
                    {
                        // Dispose previous image to avoid memory leak
                        if (pictureBoxCamera.Image != null)
                        {
                            pictureBoxCamera.Image.Dispose();
                        }

                        // clone again for UI safety
                        pictureBoxCamera.Image = (Bitmap)bitmap.Clone(); 
                    }));
                }

                // Decode QR code
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);

                bitmap.Dispose(); // dispose after decoding

                if (result != null)
                {
                    string scannedID = result.Text;

                    // Stop camera safely
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                    }

                    // Fetch student info
                    this.Invoke(new Action(() =>
                    {
                        FetchStudentInfo(scannedID);
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Frame error: " + ex.Message);
                }));
            }
        }

        // Function to close the camera
        public void CloseCamera()
        {
            try
            {
                if(videoSource != null)
                {
                    if(videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }

                    videoSource.NewFrame -= new NewFrameEventHandler(Video_NewFrame);
                    videoSource = null;
                }
                // Clear the PictureBox
                if(pictureBoxCamera.Image != null)
                {
                    pictureBoxCamera.Image.Dispose();
                    pictureBoxCamera.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing camera: " + ex.Message);
            }
        }

        // Fetch students data from database
        private void FetchStudentInfo(string studentID)
        {
            string connStr = "server=localhost;user=root;password=;database=student_records";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students WHERE student_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Create the StudentInfoForm
                        StudentInfoForm infoForm = new StudentInfoForm();

                        // Pass the data to the labels
                        infoForm.SetStudentData(
                            reader["student_id"].ToString(),
                            reader["full_name"].ToString(),
                            reader["program"].ToString(),
                            reader["year_level"].ToString(),
                            reader["section"].ToString(),
                            reader["status"].ToString(),
                            reader["email"].ToString(),
                            reader["phone_number"].ToString(),
                            reader["address"].ToString()
                        );
                        if (!reader.IsDBNull(reader.GetOrdinal("photo_path")))
                        {
                            string fileName = reader["photo_path"].ToString();

                            // Build full path to Images folder inside my workspace
                            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                            string fullPath = Path.Combine(imagesFolder, fileName);

                            if (File.Exists(fullPath))
                            {
                                infoForm.SetStudentImage(fullPath);
                            }
                            else
                            {
                                MessageBox.Show("Image not found at: " + fullPath);
                            }
                        }

                        infoForm.Show();
                        txtManualInput.Clear();

                    }

                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void QR_Code_FormClosing(object sender, FormClosingEventArgs e)
        {
                CloseCamera();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string manualID = txtManualInput.Text.Trim();
            if (!string.IsNullOrEmpty(manualID))
            {
                FetchStudentInfo(manualID);
            }
        }

        private void txtManualInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string manualID = txtManualInput.Text.Trim();
                if (!string.IsNullOrEmpty(manualID))
                {
                    FetchStudentInfo(manualID);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseCamera();
        }

        private void QR_Code_Load(object sender, EventArgs e)
        {

        }
    }
}
