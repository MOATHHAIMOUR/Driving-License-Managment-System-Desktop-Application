namespace DVLD_Project.Forms.License.InternationalLicense
{
    partial class frmnternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnternationalLicenseInfo));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkShowLicenseHistory = new LinkLabel();
            linkShowLicenseInfo = new LinkLabel();
            btnClose = new Button();
            btnIssueInternational = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            lbLocalLicenseID = new Label();
            lbCreatedBy = new Label();
            lbInternationalLicenseID = new Label();
            lbExpDate = new Label();
            lbIssueDate = new Label();
            lbAppDate = new Label();
            lbFees = new Label();
            lbAppID = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            ctrlDriverLicenseInfoWithFilter1 = new Controls.ctrlDriverLicenseInfoWithFilter();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(277, 129);
            label2.Name = "label2";
            label2.Size = new Size(460, 32);
            label2.TabIndex = 21;
            label2.Text = "International License Application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.licensing;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(365, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 114);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(579, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 49);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // linkShowLicenseHistory
            // 
            linkShowLicenseHistory.AutoSize = true;
            linkShowLicenseHistory.Location = new Point(41, 751);
            linkShowLicenseHistory.Name = "linkShowLicenseHistory";
            linkShowLicenseHistory.Size = new Size(148, 20);
            linkShowLicenseHistory.TabIndex = 25;
            linkShowLicenseHistory.TabStop = true;
            linkShowLicenseHistory.Text = "Show License History";
            linkShowLicenseHistory.LinkClicked += linkShowLicenseGistory_LinkClicked;
            // 
            // linkShowLicenseInfo
            // 
            linkShowLicenseInfo.AutoSize = true;
            linkShowLicenseInfo.Enabled = false;
            linkShowLicenseInfo.Location = new Point(206, 751);
            linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            linkShowLicenseInfo.Size = new Size(127, 20);
            linkShowLicenseInfo.TabIndex = 26;
            linkShowLicenseInfo.TabStop = true;
            linkShowLicenseInfo.Text = "Show License Info";
            linkShowLicenseInfo.LinkClicked += linkShowLicenseInfo_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Location = new Point(754, 767);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 39);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnIssueInternational
            // 
            btnIssueInternational.BackColor = SystemColors.ControlLight;
            btnIssueInternational.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnIssueInternational.Location = new Point(863, 767);
            btnIssueInternational.Name = "btnIssueInternational";
            btnIssueInternational.Size = new Size(116, 39);
            btnIssueInternational.TabIndex = 27;
            btnIssueInternational.Text = "Issue";
            btnIssueInternational.UseVisualStyleBackColor = false;
            btnIssueInternational.Click += btnIssueInternational_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbLocalLicenseID);
            groupBox1.Controls.Add(lbCreatedBy);
            groupBox1.Controls.Add(lbInternationalLicenseID);
            groupBox1.Controls.Add(lbExpDate);
            groupBox1.Controls.Add(lbIssueDate);
            groupBox1.Controls.Add(lbAppDate);
            groupBox1.Controls.Add(lbFees);
            groupBox1.Controls.Add(lbAppID);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 584);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 153);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "International Application Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 40);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 3;
            label7.Text = "I.L.D.LincenseID :";
            // 
            // lbLocalLicenseID
            // 
            lbLocalLicenseID.AutoSize = true;
            lbLocalLicenseID.Location = new Point(612, 67);
            lbLocalLicenseID.Name = "lbLocalLicenseID";
            lbLocalLicenseID.Size = new Size(24, 23);
            lbLocalLicenseID.TabIndex = 13;
            lbLocalLicenseID.Text = "??";
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Location = new Point(612, 121);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(24, 23);
            lbCreatedBy.TabIndex = 12;
            lbCreatedBy.Text = "??";
            // 
            // lbInternationalLicenseID
            // 
            lbInternationalLicenseID.AutoSize = true;
            lbInternationalLicenseID.Location = new Point(612, 40);
            lbInternationalLicenseID.Name = "lbInternationalLicenseID";
            lbInternationalLicenseID.Size = new Size(24, 23);
            lbInternationalLicenseID.TabIndex = 11;
            lbInternationalLicenseID.Text = "??";
            // 
            // lbExpDate
            // 
            lbExpDate.AutoSize = true;
            lbExpDate.Location = new Point(612, 94);
            lbExpDate.Name = "lbExpDate";
            lbExpDate.Size = new Size(24, 23);
            lbExpDate.TabIndex = 10;
            lbExpDate.Text = "??";
            // 
            // lbIssueDate
            // 
            lbIssueDate.AutoSize = true;
            lbIssueDate.Location = new Point(201, 92);
            lbIssueDate.Name = "lbIssueDate";
            lbIssueDate.Size = new Size(24, 23);
            lbIssueDate.TabIndex = 9;
            lbIssueDate.Text = "??";
            // 
            // lbAppDate
            // 
            lbAppDate.AutoSize = true;
            lbAppDate.Location = new Point(201, 63);
            lbAppDate.Name = "lbAppDate";
            lbAppDate.Size = new Size(24, 23);
            lbAppDate.TabIndex = 7;
            lbAppDate.Text = "??";
            // 
            // lbFees
            // 
            lbFees.AutoSize = true;
            lbFees.Location = new Point(201, 121);
            lbFees.Name = "lbFees";
            lbFees.Size = new Size(24, 23);
            lbFees.TabIndex = 8;
            lbFees.Text = "??";
            // 
            // lbAppID
            // 
            lbAppID.AutoSize = true;
            lbAppID.Location = new Point(201, 34);
            lbAppID.Name = "lbAppID";
            lbAppID.Size = new Size(24, 23);
            lbAppID.TabIndex = 6;
            lbAppID.Text = "??";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 67);
            label9.Name = "label9";
            label9.Size = new Size(146, 23);
            label9.TabIndex = 5;
            label9.Text = "Local License ID :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 121);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 4;
            label8.Text = "Created By :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 92);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 2;
            label5.Text = "Issue Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 63);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 1;
            label4.Text = "Application Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 121);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 1;
            label6.Text = "Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 94);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 1;
            label3.Text = "ExpDate :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "I.L.DAppID :";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 177);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(966, 401);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 31;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // frmnternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 821);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnIssueInternational);
            Controls.Add(linkShowLicenseInfo);
            Controls.Add(linkShowLicenseHistory);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "frmnternationalLicenseInfo";
            Text = "frmInternationalLicenseInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkShowLicenseHistory;
        private LinkLabel linkShowLicenseInfo;
        private Button btnClose;
        private Button btnIssueInternational;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label lbLocalLicenseID;
        private Label lbCreatedBy;
        private Label lbInternationalLicenseID;
        private Label lbExpDate;
        private Label lbIssueDate;
        private Label lbAppDate;
        private Label lbFees;
        private Label lbAppID;
        private Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}