using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MySqlConnector;
using ZXing;
using ZXing.Common;

namespace Student_ID_Scanning_System
{
    public partial class Barcode : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public Barcode()
        {
            InitializeComponent();
        }

        private void txtIDManual_Click(object sender, EventArgs e)
        {
            if (lblIDManual != null)
            {
                lblIDManual.Dispose();
            }
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
           
        }

        public Bitmap GenerateBarcode(string data)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 10
                }
            };
            return writer.Write(data);
        }


        // Open camera
        private void btnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "This feature requires access to your camera.\n\nDo you want to allow camera access?",
                    "Camera Access Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No) return;

                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No camera detected.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming the first camera is the desired one
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

        // Display camera 
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = null;
            try
            {
                bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Display the current frame in the PictureBox
                if (pictureBoxCamera.InvokeRequired)
                {
                    pictureBoxCamera.Invoke(new MethodInvoker(delegate
                    {
                        if (pictureBoxCamera.Image != null)
                            pictureBoxCamera.Image.Dispose();

                        pictureBoxCamera.Image = (Bitmap)bitmap.Clone();
                    }));
                }

                // Types of barcode 
                var reader = new BarcodeReader
                {
                    Options = new ZXing.Common.DecodingOptions
                    {
                        PossibleFormats = new List<BarcodeFormat>
                        {
                            BarcodeFormat.CODE_128,
                            BarcodeFormat.CODE_39,
                            BarcodeFormat.EAN_13,
                            BarcodeFormat.EAN_8,
                            BarcodeFormat.UPC_A,
                            BarcodeFormat.UPC_E,
                            BarcodeFormat.ITF
                        },
                        TryHarder = true 
                    }
                };

                var result = reader.Decode(bitmap);

                // Dispose of the working bitmap immediately after decoding attempt
                bitmap.Dispose();
                bitmap = null;

                if (result != null)
                {
                    string scannedID = result.Text.Trim();

                    // Stop the camera feed once a valid barcode is scanned
                    if (videoSource.IsRunning)
                        videoSource.SignalToStop();

                    this.Invoke(new Action(() =>
                    {
                        // Process the scanned ID
                        FetchStudentInfo(scannedID);
                    }));
                }
            }
            catch (Exception ex)
            {
                // Ensure bitmap is disposed even on error
                if (bitmap != null)
                {
                    bitmap.Dispose();
                }

                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Frame error: " + ex.Message);
                }));
            }
        }

        // Close camera
        public void CloseCamera()
        {
            try
            {
                if (videoSource != null)
                {
                    if (videoSource.IsRunning)
                    {
                        // Signal to stop and wait for it to stop
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }

                    videoSource.NewFrame -= new NewFrameEventHandler(Video_NewFrame);
                    videoSource = null;
                }

                if (pictureBoxCamera.Image != null)
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

        private void FetchStudentInfo(string studentID)
        {
            // normalize input
            studentID = studentID.Trim(); 

            // display data what was scanned
            MessageBox.Show("Scanned ID: [" + studentID + "]", "Scanned ID", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string connStr = "server=localhost;user=root;password=;database=student_records";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Check both barcode_id and student_id
                    string query = "SELECT * FROM students WHERE barcode_id = @id OR student_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StudentInfoForm infoForm = new StudentInfoForm();
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
                                string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                                string fullPath = Path.Combine(imagesFolder, fileName);

                                if (File.Exists(fullPath))
                                    infoForm.SetStudentImage(fullPath);
                                else
                                    MessageBox.Show("Image not found at: " + fullPath,
                                        "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            infoForm.Show();
                            txtIDManual.Clear();
                        }
                        else
                        {
                            MessageBox.Show($"Student not found for ID: {studentID}",
                                "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection or query error: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Barcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure the camera is closed when the form closes
            CloseCamera();
        }

        // Manual input via button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string manualID = txtIDManual.Text.Trim();
            if (!string.IsNullOrEmpty(manualID))
            {
                FetchStudentInfo(manualID);
            }
            else
            {
                MessageBox.Show("Please enter a Student ID manually.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Manual input via Enter key
        private void txtIDManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                btnAdd_Click(sender, e); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the camera before closing the form
            CloseCamera();
            this.Close();
        }
    }
}