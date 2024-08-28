namespace DVLD_Project.Forms.ApplicationsForms.RenewLocalDrivingLicense
{
    partial class frmRenewLicenseApplication
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
            ctrlDriverLicenseInfoWithFilter1 = new License.Controls.ctrlDriverLicenseInfoWithFilter();
            label1 = new Label();
            button1 = new Button();
            btnRenew = new Button();
            linkLicenseHistory = new LinkLabel();
            linkShowLicenseInfo = new LinkLabel();
            groupBox1 = new GroupBox();
            txtNotes = new TextBox();
            label6 = new Label();
            lbExppDate = new Label();
            lbTotalFees = new Label();
            lbCreatedBy = new Label();
            lbOldLicenseID = new Label();
            lbRLID = new Label();
            lbIssue_Date = new Label();
            lbLicenseFees = new Label();
            lbAppFees = new Label();
            lbAppDate = new Label();
            lbRLAppID = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(13, 60);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(977, 431);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 1;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(320, 19);
            label1.Name = "label1";
            label1.Size = new Size(364, 38);
            label1.TabIndex = 2;
            label1.Text = "Renew License Application";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(765, 793);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 45;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = SystemColors.ControlLight;
            btnRenew.Enabled = false;
            btnRenew.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRenew.Location = new Point(874, 793);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(103, 39);
            btnRenew.TabIndex = 46;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // linkLicenseHistory
            // 
            linkLicenseHistory.AutoSize = true;
            linkLicenseHistory.Location = new Point(34, 793);
            linkLicenseHistory.Name = "linkLicenseHistory";
            linkLicenseHistory.Size = new Size(148, 20);
            linkLicenseHistory.TabIndex = 47;
            linkLicenseHistory.TabStop = true;
            linkLicenseHistory.Text = "Show License History";
            linkLicenseHistory.LinkClicked += btnShowLicenseHistory_LinkClicked;
            // 
            // linkShowLicenseInfo
            // 
            linkShowLicenseInfo.AutoSize = true;
            linkShowLicenseInfo.Location = new Point(186, 793);
            linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            linkShowLicenseInfo.Size = new Size(161, 20);
            linkShowLicenseInfo.TabIndex = 48;
            linkShowLicenseInfo.TabStop = true;
            linkShowLicenseInfo.Text = "Show New License Info";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbExppDate);
            groupBox1.Controls.Add(lbTotalFees);
            groupBox1.Controls.Add(lbCreatedBy);
            groupBox1.Controls.Add(lbOldLicenseID);
            groupBox1.Controls.Add(lbRLID);
            groupBox1.Controls.Add(lbIssue_Date);
            groupBox1.Controls.Add(lbLicenseFees);
            groupBox1.Controls.Add(lbAppFees);
            groupBox1.Controls.Add(lbAppDate);
            groupBox1.Controls.Add(lbRLAppID);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 480);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 296);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Renew License Info";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(111, 208);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(589, 66);
            txtNotes.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 208);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 26;
            label6.Text = "Notes : ";
            // 
            // lbExppDate
            // 
            lbExppDate.AutoSize = true;
            lbExppDate.Location = new Point(673, 107);
            lbExppDate.Name = "lbExppDate";
            lbExppDate.Size = new Size(24, 23);
            lbExppDate.TabIndex = 24;
            lbExppDate.Text = "??";
            // 
            // lbTotalFees
            // 
            lbTotalFees.AutoSize = true;
            lbTotalFees.Location = new Point(673, 167);
            lbTotalFees.Name = "lbTotalFees";
            lbTotalFees.Size = new Size(24, 23);
            lbTotalFees.TabIndex = 23;
            lbTotalFees.Text = "??";
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Location = new Point(673, 137);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(24, 23);
            lbCreatedBy.TabIndex = 22;
            lbCreatedBy.Text = "??";
            // 
            // lbOldLicenseID
            // 
            lbOldLicenseID.AutoSize = true;
            lbOldLicenseID.Location = new Point(673, 77);
            lbOldLicenseID.Name = "lbOldLicenseID";
            lbOldLicenseID.Size = new Size(24, 23);
            lbOldLicenseID.TabIndex = 21;
            lbOldLicenseID.Text = "??";
            // 
            // lbRLID
            // 
            lbRLID.AutoSize = true;
            lbRLID.Location = new Point(673, 47);
            lbRLID.Name = "lbRLID";
            lbRLID.Size = new Size(24, 23);
            lbRLID.TabIndex = 20;
            lbRLID.Text = "??";
            // 
            // lbIssue_Date
            // 
            lbIssue_Date.AutoSize = true;
            lbIssue_Date.Location = new Point(196, 107);
            lbIssue_Date.Name = "lbIssue_Date";
            lbIssue_Date.Size = new Size(24, 23);
            lbIssue_Date.TabIndex = 19;
            lbIssue_Date.Text = "??";
            // 
            // lbLicenseFees
            // 
            lbLicenseFees.AutoSize = true;
            lbLicenseFees.Location = new Point(196, 167);
            lbLicenseFees.Name = "lbLicenseFees";
            lbLicenseFees.Size = new Size(24, 23);
            lbLicenseFees.TabIndex = 16;
            lbLicenseFees.Text = "??";
            // 
            // lbAppFees
            // 
            lbAppFees.AutoSize = true;
            lbAppFees.Location = new Point(196, 137);
            lbAppFees.Name = "lbAppFees";
            lbAppFees.Size = new Size(24, 23);
            lbAppFees.TabIndex = 15;
            lbAppFees.Text = "??";
            // 
            // lbAppDate
            // 
            lbAppDate.AutoSize = true;
            lbAppDate.Location = new Point(196, 77);
            lbAppDate.Name = "lbAppDate";
            lbAppDate.Size = new Size(24, 23);
            lbAppDate.TabIndex = 14;
            lbAppDate.Text = "??";
            // 
            // lbRLAppID
            // 
            lbRLAppID.AutoSize = true;
            lbRLAppID.Location = new Point(196, 47);
            lbRLAppID.Name = "lbRLAppID";
            lbRLAppID.Size = new Size(24, 23);
            lbRLAppID.TabIndex = 12;
            lbRLAppID.Text = "??";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(479, 107);
            label13.Name = "label13";
            label13.Size = new Size(150, 23);
            label13.TabIndex = 11;
            label13.Text = "Expiration Date : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(479, 167);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 10;
            label12.Text = "Total Fees";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 137);
            label11.Name = "label11";
            label11.Size = new Size(113, 23);
            label11.TabIndex = 9;
            label11.Text = "Created By : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 77);
            label10.Name = "label10";
            label10.Size = new Size(134, 23);
            label10.TabIndex = 8;
            label10.Text = "Old License ID :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 107);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 7;
            label9.Text = "issueDate :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 47);
            label8.Name = "label8";
            label8.Size = new Size(169, 23);
            label8.TabIndex = 6;
            label8.Text = "Renewd License ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 167);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 3;
            label5.Text = "License Fees :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 137);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 2;
            label4.Text = "Application Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 77);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 1;
            label3.Text = "Application Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 47);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 0;
            label2.Text = "R.L.ApplicationID :";
            // 
            // frmRenewLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 843);
            Controls.Add(groupBox1);
            Controls.Add(linkShowLicenseInfo);
            Controls.Add(linkLicenseHistory);
            Controls.Add(btnRenew);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Name = "frmRenewLicenseApplication";
            Text = "frmRenewLicenseApplication";
            Load += frmRenewLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Label label1;
        private Button button1;
        private Button btnRenew;
        private LinkLabel linkLicenseHistory;
        private LinkLabel linkShowLicenseInfo;
        private GroupBox groupBox1;
        private TextBox txtNotes;
        private Label label6;
        private Label lbExppDate;
        private Label lbTotalFees;
        private Label lbCreatedBy;
        private Label lbOldLicenseID;
        private Label lbRLID;
        private Label lbIssue_Date;
        private Label lbLicenseFees;
        private Label lbAppFees;
        private Label lbAppDate;
        private Label lbRLAppID;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}