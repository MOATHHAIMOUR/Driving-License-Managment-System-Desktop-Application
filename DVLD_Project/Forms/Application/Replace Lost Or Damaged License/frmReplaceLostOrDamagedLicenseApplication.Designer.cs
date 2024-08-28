namespace DVLD_Project.Forms.ApplicationsForms
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            lbHeader = new Label();
            groupBox1 = new GroupBox();
            lbCreatedBy = new Label();
            lbOldLicenseID = new Label();
            lbRLID = new Label();
            lbAppFees = new Label();
            lbAppDate = new Label();
            lbLRAppID = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkShowLicenseInfo = new LinkLabel();
            btnlinkShowLicenseHistory = new LinkLabel();
            btnReplacment = new Button();
            button1 = new Button();
            gbReplecmentFor = new GroupBox();
            rdLost = new RadioButton();
            rdDamageLicense = new RadioButton();
            groupBox1.SuspendLayout();
            gbReplecmentFor.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(8, 79);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(961, 435);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Firebrick;
            lbHeader.Location = new Point(223, 30);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(533, 46);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Replacment For Lost Or Damage";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCreatedBy);
            groupBox1.Controls.Add(lbOldLicenseID);
            groupBox1.Controls.Add(lbRLID);
            groupBox1.Controls.Add(lbAppFees);
            groupBox1.Controls.Add(lbAppDate);
            groupBox1.Controls.Add(lbLRAppID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 480);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 166);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info For Replacment";
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Location = new Point(685, 107);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(24, 23);
            lbCreatedBy.TabIndex = 22;
            lbCreatedBy.Text = "??";
            // 
            // lbOldLicenseID
            // 
            lbOldLicenseID.AutoSize = true;
            lbOldLicenseID.Location = new Point(685, 77);
            lbOldLicenseID.Name = "lbOldLicenseID";
            lbOldLicenseID.Size = new Size(24, 23);
            lbOldLicenseID.TabIndex = 21;
            lbOldLicenseID.Text = "??";
            // 
            // lbRLID
            // 
            lbRLID.AutoSize = true;
            lbRLID.Location = new Point(685, 47);
            lbRLID.Name = "lbRLID";
            lbRLID.Size = new Size(24, 23);
            lbRLID.TabIndex = 20;
            lbRLID.Text = "??";
            // 
            // lbAppFees
            // 
            lbAppFees.AutoSize = true;
            lbAppFees.Location = new Point(196, 107);
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
            // lbLRAppID
            // 
            lbLRAppID.AutoSize = true;
            lbLRAppID.Location = new Point(196, 47);
            lbLRAppID.Name = "lbLRAppID";
            lbLRAppID.Size = new Size(24, 23);
            lbLRAppID.TabIndex = 12;
            lbLRAppID.Text = "??";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 107);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 47);
            label8.Name = "label8";
            label8.Size = new Size(200, 23);
            label8.TabIndex = 6;
            label8.Text = "Replcament License ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 107);
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
            label2.Text = "L.R.ApplicationID :";
            // 
            // linkShowLicenseInfo
            // 
            linkShowLicenseInfo.AutoSize = true;
            linkShowLicenseInfo.Location = new Point(179, 658);
            linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            linkShowLicenseInfo.Size = new Size(161, 20);
            linkShowLicenseInfo.TabIndex = 52;
            linkShowLicenseInfo.TabStop = true;
            linkShowLicenseInfo.Text = "Show New License Info";
            // 
            // btnlinkShowLicenseHistory
            // 
            btnlinkShowLicenseHistory.AutoSize = true;
            btnlinkShowLicenseHistory.Enabled = false;
            btnlinkShowLicenseHistory.Location = new Point(27, 658);
            btnlinkShowLicenseHistory.Name = "btnlinkShowLicenseHistory";
            btnlinkShowLicenseHistory.Size = new Size(148, 20);
            btnlinkShowLicenseHistory.TabIndex = 51;
            btnlinkShowLicenseHistory.TabStop = true;
            btnlinkShowLicenseHistory.Text = "Show License History";
            // 
            // btnReplacment
            // 
            btnReplacment.BackColor = SystemColors.ControlLight;
            btnReplacment.Enabled = false;
            btnReplacment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnReplacment.Location = new Point(745, 668);
            btnReplacment.Name = "btnReplacment";
            btnReplacment.Size = new Size(224, 39);
            btnReplacment.TabIndex = 50;
            btnReplacment.Text = "Issue Replacment";
            btnReplacment.UseVisualStyleBackColor = false;
            btnReplacment.Click += btnReplacment_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(636, 668);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 49;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // gbReplecmentFor
            // 
            gbReplecmentFor.Controls.Add(rdLost);
            gbReplecmentFor.Controls.Add(rdDamageLicense);
            gbReplecmentFor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbReplecmentFor.Location = new Point(776, 50);
            gbReplecmentFor.Name = "gbReplecmentFor";
            gbReplecmentFor.Size = new Size(186, 154);
            gbReplecmentFor.TabIndex = 53;
            gbReplecmentFor.TabStop = false;
            gbReplecmentFor.Text = "Replacment For";
            // 
            // rdLost
            // 
            rdLost.AutoSize = true;
            rdLost.Location = new Point(6, 97);
            rdLost.Name = "rdLost";
            rdLost.Size = new Size(126, 27);
            rdLost.TabIndex = 1;
            rdLost.TabStop = true;
            rdLost.Text = "Lost License";
            rdLost.UseVisualStyleBackColor = true;
            rdLost.CheckedChanged += rdLost_CheckedChanged;
            rdLost.MouseClick += LostOrDamage_MouseClick;
            // 
            // rdDamageLicense
            // 
            rdDamageLicense.AutoSize = true;
            rdDamageLicense.Location = new Point(6, 49);
            rdDamageLicense.Name = "rdDamageLicense";
            rdDamageLicense.Size = new Size(160, 27);
            rdDamageLicense.TabIndex = 0;
            rdDamageLicense.TabStop = true;
            rdDamageLicense.Text = "Damage License";
            rdDamageLicense.UseVisualStyleBackColor = true;
            rdDamageLicense.CheckedChanged += rdDamageLicense_CheckedChanged;
            rdDamageLicense.MouseClick += LostOrDamage_MouseClick;
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 721);
            Controls.Add(gbReplecmentFor);
            Controls.Add(linkShowLicenseInfo);
            Controls.Add(btnlinkShowLicenseHistory);
            Controls.Add(groupBox1);
            Controls.Add(btnReplacment);
            Controls.Add(lbHeader);
            Controls.Add(button1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Name = "frmReplaceLostOrDamagedLicenseApplication";
            Text = "frmLostOrDamage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbReplecmentFor.ResumeLayout(false);
            gbReplecmentFor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Label lbHeader;
        private GroupBox groupBox1;
        private Label lbCreatedBy;
        private Label lbOldLicenseID;
        private Label lbRLID;
        private Label lbAppFees;
        private Label lbAppDate;
        private Label lbLRAppID;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkShowLicenseInfo;
        private LinkLabel btnlinkShowLicenseHistory;
        private Button btnReplacment;
        private Button button1;
        private GroupBox gbReplecmentFor;
        private RadioButton rdLost;
        private RadioButton rdDamageLicense;
    }
}