namespace Student_ID_Scanning_System
{
    partial class Scan_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan_Screen));
            this.lblNumberID = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pNotification = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblScanID = new System.Windows.Forms.Label();
            this.lblStudentRecord = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pSidebar = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudentRecord = new System.Windows.Forms.Button();
            this.btnScanID = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnRFID = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pBody = new System.Windows.Forms.Panel();
            this.pHeader.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberID
            // 
            this.lblNumberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumberID.AutoSize = true;
            this.lblNumberID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.lblNumberID.Location = new System.Drawing.Point(237, 15);
            this.lblNumberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberID.Name = "lblNumberID";
            this.lblNumberID.Size = new System.Drawing.Size(156, 21);
            this.lblNumberID.TabIndex = 4;
            this.lblNumberID.Text = "ID Number: 2300505";
            // 
            // pHeader
            // 
            this.pHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.pHeader.Controls.Add(this.panel6);
            this.pHeader.Controls.Add(this.pNotification);
            this.pHeader.Controls.Add(this.lblNumberID);
            this.pHeader.Controls.Add(this.lblName);
            this.pHeader.Location = new System.Drawing.Point(229, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1314, 55);
            this.pHeader.TabIndex = 59;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(1256, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 22);
            this.panel6.TabIndex = 8;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Student_ID_Scanning_System.Properties.Resources.profile_icon;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pNotification
            // 
            this.pNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNotification.Controls.Add(this.pictureBox2);
            this.pNotification.Location = new System.Drawing.Point(1187, 15);
            this.pNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pNotification.Name = "pNotification";
            this.pNotification.Size = new System.Drawing.Size(22, 22);
            this.pNotification.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Student_ID_Scanning_System.Properties.Resources.notification_icon;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.lblName.Location = new System.Drawing.Point(14, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "MOLLEJON, ISRAEL D.";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 2);
            this.panel4.TabIndex = 39;
            // 
            // lblScanID
            // 
            this.lblScanID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScanID.AutoSize = true;
            this.lblScanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblScanID.Location = new System.Drawing.Point(40, 234);
            this.lblScanID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScanID.Name = "lblScanID";
            this.lblScanID.Size = new System.Drawing.Size(67, 21);
            this.lblScanID.TabIndex = 42;
            this.lblScanID.Text = "Scan ID";
            // 
            // lblStudentRecord
            // 
            this.lblStudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentRecord.AutoSize = true;
            this.lblStudentRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblStudentRecord.Location = new System.Drawing.Point(40, 303);
            this.lblStudentRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentRecord.Name = "lblStudentRecord";
            this.lblStudentRecord.Size = new System.Drawing.Size(116, 21);
            this.lblStudentRecord.TabIndex = 44;
            this.lblStudentRecord.Text = "Student Record";
            this.lblStudentRecord.Click += new System.EventHandler(this.lblStudentRecord_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblDashboard.Location = new System.Drawing.Point(40, 165);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(86, 21);
            this.lblDashboard.TabIndex = 45;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblLogout.Location = new System.Drawing.Point(40, 730);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(59, 21);
            this.lblLogout.TabIndex = 47;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.panel5.Location = new System.Drawing.Point(0, 708);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 2);
            this.panel5.TabIndex = 48;
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.pSidebar.Controls.Add(this.lblReports);
            this.pSidebar.Controls.Add(this.btnReports);
            this.pSidebar.Controls.Add(this.panel5);
            this.pSidebar.Controls.Add(this.lblLogout);
            this.pSidebar.Controls.Add(this.btnLogout);
            this.pSidebar.Controls.Add(this.lblDashboard);
            this.pSidebar.Controls.Add(this.lblStudentRecord);
            this.pSidebar.Controls.Add(this.btnStudentRecord);
            this.pSidebar.Controls.Add(this.lblScanID);
            this.pSidebar.Controls.Add(this.btnScanID);
            this.pSidebar.Controls.Add(this.btnDashboard);
            this.pSidebar.Controls.Add(this.panel4);
            this.pSidebar.Controls.Add(this.pictureBox1);
            this.pSidebar.Location = new System.Drawing.Point(0, -2);
            this.pSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(229, 846);
            this.pSidebar.TabIndex = 61;
            // 
            // lblReports
            // 
            this.lblReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblReports.Location = new System.Drawing.Point(40, 378);
            this.lblReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(64, 21);
            this.lblReports.TabIndex = 51;
            this.lblReports.Text = "Reports";
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnReports.Image = global::Student_ID_Scanning_System.Properties.Resources.scan_history_icon__1_;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 363);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(229, 56);
            this.btnReports.TabIndex = 50;
            this.btnReports.TabStop = false;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 715);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 56);
            this.btnLogout.TabIndex = 46;
            this.btnLogout.TabStop = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudentRecord
            // 
            this.btnStudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudentRecord.FlatAppearance.BorderSize = 0;
            this.btnStudentRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnStudentRecord.Image = global::Student_ID_Scanning_System.Properties.Resources.student_record_icon;
            this.btnStudentRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentRecord.Location = new System.Drawing.Point(0, 287);
            this.btnStudentRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentRecord.Name = "btnStudentRecord";
            this.btnStudentRecord.Size = new System.Drawing.Size(229, 56);
            this.btnStudentRecord.TabIndex = 43;
            this.btnStudentRecord.TabStop = false;
            this.btnStudentRecord.UseVisualStyleBackColor = true;
            this.btnStudentRecord.Click += new System.EventHandler(this.btnStudentRecord_Click);
            // 
            // btnScanID
            // 
            this.btnScanID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScanID.FlatAppearance.BorderSize = 0;
            this.btnScanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnScanID.Image = ((System.Drawing.Image)(resources.GetObject("btnScanID.Image")));
            this.btnScanID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanID.Location = new System.Drawing.Point(0, 217);
            this.btnScanID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScanID.Name = "btnScanID";
            this.btnScanID.Size = new System.Drawing.Size(229, 56);
            this.btnScanID.TabIndex = 41;
            this.btnScanID.TabStop = false;
            this.btnScanID.UseVisualStyleBackColor = true;
            this.btnScanID.Click += new System.EventHandler(this.btnScanID_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnDashboard.Image = global::Student_ID_Scanning_System.Properties.Resources.dash_icon;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 149);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(229, 56);
            this.btnDashboard.TabIndex = 40;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnBarcode.FlatAppearance.BorderSize = 0;
            this.btnBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnBarcode.Location = new System.Drawing.Point(27, 8);
            this.btnBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(329, 46);
            this.btnBarcode.TabIndex = 35;
            this.btnBarcode.TabStop = false;
            this.btnBarcode.Text = "BARCODE";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnQR
            // 
            this.btnQR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnQR.Location = new System.Drawing.Point(426, 8);
            this.btnQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(329, 46);
            this.btnQR.TabIndex = 36;
            this.btnQR.TabStop = false;
            this.btnQR.Text = "QR CODE";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnRFID
            // 
            this.btnRFID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnRFID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRFID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnRFID.FlatAppearance.BorderSize = 0;
            this.btnRFID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnRFID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.btnRFID.Location = new System.Drawing.Point(830, 8);
            this.btnRFID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(329, 46);
            this.btnRFID.TabIndex = 37;
            this.btnRFID.TabStop = false;
            this.btnRFID.Text = "RFID";
            this.btnRFID.UseVisualStyleBackColor = false;
            this.btnRFID.Click += new System.EventHandler(this.btnRFID_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 62);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(790, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 62);
            this.panel3.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRFID);
            this.panel1.Controls.Add(this.btnQR);
            this.panel1.Controls.Add(this.btnBarcode);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(289, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 62);
            this.panel1.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(59)))));
            this.label16.Location = new System.Drawing.Point(285, 85);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 21);
            this.label16.TabIndex = 57;
            this.label16.Text = "SCANNER TYPE";
            // 
            // pBody
            // 
            this.pBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBody.Location = new System.Drawing.Point(234, 192);
            this.pBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(1302, 653);
            this.pBody.TabIndex = 60;
            // 
            // Scan_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1539, 844);
            this.Controls.Add(this.pSidebar);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBody);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Scan_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Scan_Screen_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberID;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnScanID;
        private System.Windows.Forms.Label lblScanID;
        private System.Windows.Forms.Button btnStudentRecord;
        private System.Windows.Forms.Label lblStudentRecord;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pSidebar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pNotification;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pBody;
    }
}