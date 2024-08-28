namespace DVLD_Project.Forms.ApplicationsForms
{
    partial class frmLocalDrivingLicensesManagment
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtFilterValue = new TextBox();
            btnAddLocalLicenseApplication = new Panel();
            label2 = new Label();
            comboFilterBy = new ComboBox();
            label1 = new Label();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            contexLocalApplication = new ContextMenuStrip(components);
            showApplicationDetialsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuSechudelTestTool = new ToolStripMenuItem();
            sechudelToolStripMenuItem = new ToolStripMenuItem();
            sechudelVisionTest = new ToolStripMenuItem();
            sechudelStreetTest = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            contexLocalApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(211, 291);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 27);
            txtFilterValue.TabIndex = 22;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // btnAddLocalLicenseApplication
            // 
            btnAddLocalLicenseApplication.BackgroundImage = Properties.Resources.drivers_license;
            btnAddLocalLicenseApplication.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddLocalLicenseApplication.Cursor = Cursors.Hand;
            btnAddLocalLicenseApplication.Location = new Point(1096, 226);
            btnAddLocalLicenseApplication.Margin = new Padding(3, 4, 3, 4);
            btnAddLocalLicenseApplication.Name = "btnAddLocalLicenseApplication";
            btnAddLocalLicenseApplication.Size = new Size(98, 92);
            btnAddLocalLicenseApplication.TabIndex = 21;
            btnAddLocalLicenseApplication.MouseClick += btnAddLocalLicenseApplication_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 212);
            label2.Name = "label2";
            label2.Size = new Size(552, 39);
            label2.TabIndex = 20;
            label2.Text = "Local Driving License Application";
            // 
            // comboFilterBy
            // 
            comboFilterBy.FormattingEnabled = true;
            comboFilterBy.Items.AddRange(new object[] { "ApplicationID", "NationalNo", "FullName", "Status" });
            comboFilterBy.Location = new Point(12, 290);
            comboFilterBy.Margin = new Padding(3, 4, 3, 4);
            comboFilterBy.Name = "comboFilterBy";
            comboFilterBy.Size = new Size(193, 28);
            comboFilterBy.TabIndex = 19;
            comboFilterBy.SelectedIndexChanged += comboFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-185, 205);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 18;
            label1.Text = "Filter By";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToResizeColumns = false;
            dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalDrivingLicenseApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLocalDrivingLicenseApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.ContextMenuStrip = contexLocalApplication;
            dgvLocalDrivingLicenseApplications.Location = new Point(12, 326);
            dgvLocalDrivingLicenseApplications.Margin = new Padding(3, 4, 3, 4);
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.ReadOnly = true;
            dgvLocalDrivingLicenseApplications.RowHeadersWidth = 51;
            dgvLocalDrivingLicenseApplications.RowTemplate.Height = 24;
            dgvLocalDrivingLicenseApplications.Size = new Size(1183, 300);
            dgvLocalDrivingLicenseApplications.TabIndex = 17;
            // 
            // contexLocalApplication
            // 
            contexLocalApplication.ImageScalingSize = new Size(20, 20);
            contexLocalApplication.Items.AddRange(new ToolStripItem[] { showApplicationDetialsToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem, menuSechudelTestTool, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem });
            contexLocalApplication.Name = "contextMenuStrip1";
            contexLocalApplication.Size = new Size(315, 214);
            contexLocalApplication.Closed += contexLocalApplication_Closed;
            contexLocalApplication.Opening += contexLocalApplication_Opening;
            // 
            // showApplicationDetialsToolStripMenuItem
            // 
            showApplicationDetialsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showApplicationDetialsToolStripMenuItem.Image = Properties.Resources.list;
            showApplicationDetialsToolStripMenuItem.Name = "showApplicationDetialsToolStripMenuItem";
            showApplicationDetialsToolStripMenuItem.Size = new Size(314, 26);
            showApplicationDetialsToolStripMenuItem.Text = "Show Application Detials";
            showApplicationDetialsToolStripMenuItem.Click += showApplicationDetialsToolStripMenuItem_Click;
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(314, 26);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            editApplicationToolStripMenuItem.Click += editApplicationToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.bin;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(314, 26);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelApplicationToolStripMenuItem.Image = Properties.Resources.cancelled;
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(314, 26);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            // 
            // menuSechudelTestTool
            // 
            menuSechudelTestTool.DropDownItems.AddRange(new ToolStripItem[] { sechudelToolStripMenuItem, sechudelVisionTest, sechudelStreetTest });
            menuSechudelTestTool.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuSechudelTestTool.Image = Properties.Resources.test;
            menuSechudelTestTool.Name = "menuSechudelTestTool";
            menuSechudelTestTool.Size = new Size(314, 26);
            menuSechudelTestTool.Text = "Sechudel Test";
            // 
            // sechudelToolStripMenuItem
            // 
            sechudelToolStripMenuItem.Image = Properties.Resources.eye_scan;
            sechudelToolStripMenuItem.Name = "sechudelToolStripMenuItem";
            sechudelToolStripMenuItem.Size = new Size(245, 26);
            sechudelToolStripMenuItem.Text = "Sechudel Vision Test";
            sechudelToolStripMenuItem.Click += VisionTest;
            // 
            // sechudelVisionTest
            // 
            sechudelVisionTest.Image = Properties.Resources.test2;
            sechudelVisionTest.Name = "sechudelVisionTest";
            sechudelVisionTest.Size = new Size(245, 26);
            sechudelVisionTest.Text = "Sechudel Written Test";
            sechudelVisionTest.Click += sechudelWrittenTest_Click;
            // 
            // sechudelStreetTest
            // 
            sechudelStreetTest.Image = Properties.Resources.street;
            sechudelStreetTest.Name = "sechudelStreetTest";
            sechudelStreetTest.Size = new Size(245, 26);
            sechudelStreetTest.Text = "Sechudel Street Test";
            sechudelStreetTest.Click += sechudelStreetTest_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.stamp;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(314, 26);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicenseToolStripMenuItem.Image = Properties.Resources.license1;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(314, 26);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.licensing;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(365, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 178);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.round;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(677, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 53);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "New", "Completed", "Deleted" });
            comboStatus.Location = new Point(220, 290);
            comboStatus.Margin = new Padding(3, 4, 3, 4);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(132, 28);
            comboStatus.TabIndex = 25;
            comboStatus.SelectedIndexChanged += comboStatus_SelectedIndexChanged;
            // 
            // frmLocalDrivingLicensesManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 639);
            Controls.Add(comboStatus);
            Controls.Add(pictureBox2);
            Controls.Add(txtFilterValue);
            Controls.Add(btnAddLocalLicenseApplication);
            Controls.Add(label2);
            Controls.Add(comboFilterBy);
            Controls.Add(label1);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Controls.Add(pictureBox1);
            Name = "frmLocalDrivingLicensesManagment";
            Text = "frmApplicationsManagmet";
            Load += frmLocalDrivingLicensesManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            contexLocalApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFilterValue;
        private Panel btnAddLocalLicenseApplication;
        private Label label2;
        private ComboBox comboFilterBy;
        private Label label1;
        private DataGridView dgvLocalDrivingLicenseApplications;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ContextMenuStrip contexLocalApplication;
        private ComboBox comboStatus;
        private ToolStripMenuItem showApplicationDetialsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem menuSechudelTestTool;
        private ToolStripMenuItem sechudelToolStripMenuItem;
        private ToolStripMenuItem sechudelVisionTest;
        private ToolStripMenuItem sechudelStreetTest;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}