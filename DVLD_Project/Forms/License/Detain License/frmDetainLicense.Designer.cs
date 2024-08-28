namespace DVLD_Project.Forms.ApplicationsForms.DetainLicense
{
    partial class frmDetainLicense
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
            linkLicenseInfo = new LinkLabel();
            linkShowLicenseHistory = new LinkLabel();
            groupBox1 = new GroupBox();
            txtFines = new TextBox();
            lbCreatedBy = new Label();
            lbRLID = new Label();
            lbDetainDate = new Label();
            lbDetainID = new Label();
            label11 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDetain = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 68);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(968, 401);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // linkLicenseInfo
            // 
            linkLicenseInfo.AutoSize = true;
            linkLicenseInfo.Enabled = false;
            linkLicenseInfo.Location = new Point(183, 632);
            linkLicenseInfo.Name = "linkLicenseInfo";
            linkLicenseInfo.Size = new Size(161, 20);
            linkLicenseInfo.TabIndex = 57;
            linkLicenseInfo.TabStop = true;
            linkLicenseInfo.Text = "Show New License Info";
            // 
            // linkShowLicenseHistory
            // 
            linkShowLicenseHistory.AutoSize = true;
            linkShowLicenseHistory.Enabled = false;
            linkShowLicenseHistory.Location = new Point(31, 632);
            linkShowLicenseHistory.Name = "linkShowLicenseHistory";
            linkShowLicenseHistory.Size = new Size(148, 20);
            linkShowLicenseHistory.TabIndex = 56;
            linkShowLicenseHistory.TabStop = true;
            linkShowLicenseHistory.Text = "Show License History";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFines);
            groupBox1.Controls.Add(lbCreatedBy);
            groupBox1.Controls.Add(lbRLID);
            groupBox1.Controls.Add(lbDetainDate);
            groupBox1.Controls.Add(lbDetainID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(31, 468);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 143);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detain Info";
            // 
            // txtFines
            // 
            txtFines.Location = new Point(196, 107);
            txtFines.Name = "txtFines";
            txtFines.Size = new Size(117, 30);
            txtFines.TabIndex = 23;
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Location = new Point(673, 77);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(24, 23);
            lbCreatedBy.TabIndex = 22;
            lbCreatedBy.Text = "??";
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
            // lbDetainDate
            // 
            lbDetainDate.AutoSize = true;
            lbDetainDate.Location = new Point(196, 77);
            lbDetainDate.Name = "lbDetainDate";
            lbDetainDate.Size = new Size(24, 23);
            lbDetainDate.TabIndex = 14;
            lbDetainDate.Text = "??";
            // 
            // lbDetainID
            // 
            lbDetainID.AutoSize = true;
            lbDetainID.Location = new Point(196, 47);
            lbDetainID.Name = "lbDetainID";
            lbDetainID.Size = new Size(24, 23);
            lbDetainID.TabIndex = 12;
            lbDetainID.Text = "??";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 77);
            label11.Name = "label11";
            label11.Size = new Size(113, 23);
            label11.TabIndex = 9;
            label11.Text = "Created By : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 47);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 6;
            label8.Text = "License ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 107);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 2;
            label4.Text = "Fine Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 77);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 1;
            label3.Text = "Detain Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 47);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 0;
            label2.Text = "Detain ID";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // btnDetain
            // 
            btnDetain.BackColor = SystemColors.ControlLight;
            btnDetain.Enabled = false;
            btnDetain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDetain.Location = new Point(839, 632);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(127, 39);
            btnDetain.TabIndex = 55;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = false;
            btnDetain.Click += btnDetain_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(730, 632);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 53;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(385, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 58;
            label1.Text = "Detain License";
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 683);
            Controls.Add(label1);
            Controls.Add(linkLicenseInfo);
            Controls.Add(linkShowLicenseHistory);
            Controls.Add(btnDetain);
            Controls.Add(button1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(groupBox1);
            Enabled = false;
            Name = "frmDetainLicense";
            Text = "frmDetainLicense";
            Load += frmDetainLicense_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private LinkLabel linkLicenseInfo;
        private LinkLabel linkShowLicenseHistory;
        private GroupBox groupBox1;
        private Label lbCreatedBy;
        private Label lbRLID;
        private Label lbDetainDate;
        private Label lbDetainID;
        private Label label11;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDetain;
        private Button button1;
        private Label label1;
        private TextBox txtFines;
    }
}